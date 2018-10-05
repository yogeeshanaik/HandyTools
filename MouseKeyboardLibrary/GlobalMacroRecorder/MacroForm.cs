using GlobalMacroRecorder.Resources;
using Hotkeys;
using MouseKeyboardLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GlobalMacroRecorder
{
    public partial class MacroForm : Form
    {
        private MacroService _macroService;

        public MacroService MacroService
        {
            get
            {
                if (_macroService == null)
                    _macroService = new MacroService();
                return _macroService;
            }
        }

        public List<MacroEvent> events = new List<MacroEvent>();
        private readonly KeyboardHook keyboardHook = new KeyboardHook();
        private readonly MouseHook mouseHook = new MouseHook();
        private int lastTimeRecorded;
        private bool recording;
        private bool hotkeymessage;
        private bool foreverloopmessage;
        private readonly GlobalHotkey ghk;

        private List<MacroCollection> MacroEvents = new List<MacroCollection>();
        private string selectedMacroName = string.Empty;

        public MacroForm()
        {
            InitializeComponent();

            MiniMode();

            mouseHook.MouseMove += mouseHook_MouseMove;
            mouseHook.MouseDown += mouseHook_MouseDown;
            mouseHook.MouseUp += mouseHook_MouseUp;
            keyboardHook.KeyDown += keyboardHook_KeyDown;
            keyboardHook.KeyUp += keyboardHook_KeyUp;
            ghk = new GlobalHotkey(Constants.ESC, Keys.Escape, this);
            hotkeymessage = false;
            foreverloopmessage = false;

            MacroEvents = MacroService.Macros;
            // Load all saved Macro events
            LoadMacros();
        }

        private void MiniMode()
        {
            this.Height = 500;
            this.Width = 370;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID) HandleHotkey();
            base.WndProc(ref m);
        }

        private void HandleHotkey()
        {
            if (recording)
            {
                Stopclick();
            }
            else if (PlayWorker.IsBusy)
            {
                if (ForeverLoop.Checked)
                {
                    ForeverLoop.Checked = false;
                }
                PlayWorker.CancelAsync();
            }
        }

        private void mouseHook_MouseMove(object sender, MouseEventArgs e)
        {
            if (chkMouseMove.Checked)
            {
                var mouseEventArgs = new SerializableMouseEventArgs() { X = e.X, Y = e.Y, Button = e.Button };
                events.Add(new MacroEvent(MacroEventType.MouseMove, mouseEventArgs, Environment.TickCount - lastTimeRecorded));
                lastTimeRecorded = Environment.TickCount;
            }
        }

        private void mouseHook_MouseDown(object sender, MouseEventArgs e)
        {
            var mouseEventArgs = new SerializableMouseEventArgs() { X = e.X, Y = e.Y, Button = e.Button };
            events.Add(new MacroEvent(MacroEventType.MouseDown, mouseEventArgs, Environment.TickCount - lastTimeRecorded));
            lastTimeRecorded = Environment.TickCount;
        }

        private void mouseHook_MouseUp(object sender, MouseEventArgs e)
        {
            var mouseEventArgs = new SerializableMouseEventArgs() { X = e.X, Y = e.Y, Button = e.Button };
            events.Add(new MacroEvent(MacroEventType.MouseUp, mouseEventArgs, Environment.TickCount - lastTimeRecorded));
            lastTimeRecorded = Environment.TickCount;
        }

        private void keyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) return;
            var keyEventArgs = new SerializableKeyEventArgs() { KeyCode = e.KeyCode };
            events.Add(new MacroEvent(MacroEventType.KeyDown, keyEventArgs, Environment.TickCount - lastTimeRecorded));
            lastTimeRecorded = Environment.TickCount;
        }

        private void keyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
            var keyEventArgs = new SerializableKeyEventArgs() { KeyCode = e.KeyCode };
            events.Add(new MacroEvent(MacroEventType.KeyUp, keyEventArgs, Environment.TickCount - lastTimeRecorded));
            lastTimeRecorded = Environment.TickCount;
        }

        private void recordStartButton_Click(object sender, EventArgs e)
        {
            events.Clear();
            lastTimeRecorded = Environment.TickCount;
            keyboardHook.Start();
            mouseHook.Start();
            recording = true;
            recordStartButton.Enabled = false;
            playBackMacroButton.Enabled = false;
            recordStopButton.Enabled = true;
        }

        private void recordStopButton_Click(object sender, EventArgs e)
        {
            Stopclick();

            // Save
            if (savemacro.Checked)
            {
                FilenameForm objFileName = new FilenameForm();
                objFileName.ShowDialog();

                if (!string.IsNullOrEmpty(objFileName.Filename))
                {
                    var newItem = new MacroCollection()
                    {
                        MacroName = objFileName.Filename,
                        Events = events,
                        Description = objFileName.Description,
                        CreatedOn = DateTime.Now
                    };

                    MacroEvents.Add(newItem);
                    MacroService.SaveMacro(MacroEvents);

                    LoadMacros();
                    LoadMacroEventsToUI(objFileName.Filename);
                }
            }
        }

        private void playBackMacroButton_Click(object sender, EventArgs e)
        {
            if (Hidewindow.Checked)
            {
                Hide();
            }
            else
            {
                var selectedMacro = MacroEvents.Where(s => s.MacroName.Equals(selectedMacroName)).FirstOrDefault();
                if (selectedMacro != null)
                    events = selectedMacro.Events;

                playBackMacroButton.Enabled = false;
                recordStartButton.Enabled = false;
                recordStopButton.Enabled = true;
                progressBar1.Maximum = events.Count();
                progressBar1.Visible = true;
            }
            PlayWorker.RunWorkerAsync();
        }

        private void PlayWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var eventpass = 0;
            var previousProcessName = string.Empty;
            foreach (MacroEvent macroEvent in events)
            {
                ++eventpass;
                PlayWorker.ReportProgress(eventpass);

                if (PlayWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                //// Focus correct process
                //try
                //{
                //    if (macroEvent.CurrentProcessName == "GlobalMacroRecorder")
                //        continue;

                //    if (macroEvent.CurrentProcessName != previousProcessName)
                //        Resources.ProcessHelper.BringMainWindowToFront(macroEvent.CurrentProcessName);

                //    if (macroEvent.CurrentProcessName != "explorer")
                //        Resources.ProcessHelper.MoveWindow(macroEvent.WindowSize);
                //}
                //catch { }

                Thread.Sleep(macroEvent.TimeSinceLastEvent);

                switch (macroEvent.MacroEventType)
                {
                    case MacroEventType.MouseMove:
                        {
                            //var mouseArgs = (MouseEventArgs)macroEvent.EventArgs;
                            var mouseArgs = macroEvent.MouseEventArgs;
                            MouseSimulator.X = mouseArgs.X;
                            MouseSimulator.Y = mouseArgs.Y;
                        }
                        break;

                    case MacroEventType.MouseDown:
                        {
                            //var mouseArgs = (MouseEventArgs)macroEvent.EventArgs;
                            var mouseArgs = macroEvent.MouseEventArgs;
                            MouseSimulator.X = mouseArgs.X;
                            MouseSimulator.Y = mouseArgs.Y;
                            MouseSimulator.MouseDown(mouseArgs.Button);
                        }
                        break;

                    case MacroEventType.MouseUp:
                        {
                            //var mouseArgs = (MouseEventArgs)macroEvent.EventArgs;
                            var mouseArgs = macroEvent.MouseEventArgs;
                            MouseSimulator.X = mouseArgs.X;
                            MouseSimulator.Y = mouseArgs.Y;
                            MouseSimulator.MouseUp(mouseArgs.Button);
                        }
                        break;

                    case MacroEventType.KeyDown:
                        {
                            //var keyArgs = (KeyEventArgs)macroEvent.EventArgs;
                            var keyArgs = macroEvent.KeyEventArgs;
                            KeyboardSimulator.KeyDown(keyArgs.KeyCode);
                        }
                        break;

                    case MacroEventType.KeyUp:
                        {
                            //var keyArgs = (KeyEventArgs)macroEvent.EventArgs;
                            var keyArgs = macroEvent.KeyEventArgs;
                            KeyboardSimulator.KeyUp(keyArgs.KeyCode);
                        }
                        break;
                }
            }
        }

        private void PlayWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (!Hidewindow.Checked)
            {
                progressBar1.Value = e.ProgressPercentage;
            }
        }

        private void PlayWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (ForeverLoop.Checked)
            {
                PlayWorker.RunWorkerAsync();
            }
            else if (Hidewindow.Checked)
            {
                Show();
            }
            else
            {
                progressBar1.Visible = false;
                playBackMacroButton.Enabled = true;
                recordStartButton.Enabled = true;
                recordStopButton.Enabled = false;
            }
        }

        private void MacroForm_Click(object sender, EventArgs e)
        {
            if (stoponselect.Checked)
            {
                Stopclick();
            }
        }

        public void Stopclick()
        {
            if (recording)
            {
                keyboardHook.Stop();
                mouseHook.Stop();
                recording = false;
                recordStartButton.Enabled = true;
                playBackMacroButton.Enabled = true;
                recordStopButton.Enabled = false;
            }
            else if (PlayWorker.IsBusy)
            {
                PlayWorker.CancelAsync();
            }
        }

        private void MacroForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (stoponselect.Checked)
            {
                Stopclick();
            }
        }

        private void savemacro_CheckedChanged(object sender, EventArgs e)
        {
            //if (savemacro.Checked)
            //{
            //    MessageBox.Show(@"For all the people who want to see if this will work... it won't.", @"It will not work", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    savemacro.Checked = false;
            //}
            //try
            //{
            //    using (Stream stream = File.Open("data.bin", FileMode.Create))
            //    {
            //        var bin = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            //        bin.Serialize(stream, events);
            //    }// This will not work being that you can not serialize mouse events without creating seperate variables for x and y.
            //}
            //catch (IOException)
            //{
            //    MessageBox.Show("Could not save the file because of a system IOException. Try again later.");
            //}
        }

        private void HotkeyActivated_CheckedChanged(object sender, EventArgs e)
        {
            if (HotkeyActivated.Checked)
            {
                if (hotkeymessage == false)
                {
                    MessageBox.Show(@"The Global Hotkey for this application is 'ESC'. It will stop the recording of keyboard and mouse movements if activated. If you are playing the movements pressing it will stop the playback process. Using this you have the ability to forever loop the movements and drive your friend crazy! Have fun :)");
                    hotkeymessage = true;
                }
                ForeverLoop.Visible = true;
                ghk.Register();
            }
            else
            {
                if (ForeverLoop.Checked)
                {
                    ForeverLoop.Checked = false;
                    MessageBox.Show(@"Forever Loop was on. Deactivated it.", @"Deactivated Forever Loop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ForeverLoop.Visible = false;
                ghk.Unregiser();
            }
        }

        private void ForeverLoop_CheckedChanged(object sender, EventArgs e)
        {
            if (ForeverLoop.Checked)
            {
                if (foreverloopmessage == false)
                {
                    MessageBox.Show(@"This feature allows you to forever loop a movement playback. To get out of the playback loop please press 'ESC'. You will need to reactivate this feature when you come out.", @"Enabled Forever Loop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreverloopmessage = true;
                }
            }
        }

        private void LoadMacros()
        {           
            lstSavedMacros.Items.Clear();
            foreach (var item in MacroEvents)
                lstSavedMacros.Items.Insert(0,
    new ListViewItem(
        new[]
                    {
                    item.MacroName,
                    item.Description,
                    item.CreatedOn.ToString()
                    }));

            lstSavedMacros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstSavedMacros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void LoadMacroEventsToUI(string macroName)
        {
            var macroEventList = MacroEvents.Where(s => s.MacroName.Equals(macroName)).FirstOrDefault();

            lstMouseEvents.Items.Clear();
            lstKeyboardEvents.Items.Clear();
            foreach (var macroEvent in macroEventList.Events)
            {
                switch (macroEvent.MacroEventType)
                {
                    case MacroEventType.MouseMove:
                    case MacroEventType.MouseDown:
                    case MacroEventType.MouseUp:
                        {
                            var mouseArgs = macroEvent.MouseEventArgs;
                            AddMouseEvent(macroEvent.EventId, macroEvent.MacroEventType.ToString(), mouseArgs.Button.ToString(), mouseArgs.X.ToString(), mouseArgs.Y.ToString(), string.Empty);
                        }
                        break;

                    case MacroEventType.KeyDown:
                    case MacroEventType.KeyUp:
                        {
                            var e = macroEvent.KeyEventArgs;
                            AddKeyboardEvent(
                                macroEvent.EventId,
                                macroEvent.MacroEventType.ToString(),
                                e.KeyCode.ToString(),
                                "",
                                "", //e.Shift.ToString(),
                                "", //e.Alt.ToString(),
                                "", //e.Control.ToString()
                                macroEvent.CurrentProcessName
                                );
                        }
                        break;
                }
            }

            //lstMouseEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //lstMouseEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //lstKeyboardEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //lstKeyboardEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void AddMouseEvent(string id, string eventType, string button, string x, string y, string delta)
        {
            lstMouseEvents.Items.Insert(0,
                new ListViewItem(
                    new[]
                    {
                        id,
                        eventType,
                        button,
                        x,
                        y,
                        delta
                    }));
        }

        private void AddKeyboardEvent(string id, string eventType, string keyCode, string keyChar, string shift, string alt, string control, string processName)
        {
            lstKeyboardEvents.Items.Insert(0,
                new ListViewItem(
                    new[]
                    {
                        id,
                        eventType,
                        keyCode,
                        keyChar,
                        shift,
                        alt,
                        control,
                        processName
                    }));
        }

        private void lstSavedMacros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0)
            {
                recordStartButton.Enabled = false;
                selectedMacroName = (sender as ListView).SelectedItems[0].Text;
                LoadMacroEventsToUI(selectedMacroName);
            }
        }

        private void lstSavedMacros_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                foreach (ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                {
                    listViewItem.Remove();

                    //Remove items from MacroEventsCollection
                    MacroEvents.Remove(MacroEvents.Where(s => s.MacroName.Equals(listViewItem.Text)).FirstOrDefault());
                }
                // Update file
                MacroService.SaveMacro(MacroEvents);
            }
        }

        private void lstKeyboardEvents_KeyDown(object sender, KeyEventArgs e)
        {
            lstMouseEvents_KeyDown(sender, e);
        }

        private void lstMouseEvents_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                foreach (ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                {
                    listViewItem.Remove();

                    //Remove items from events list
                    var selectedMacro = MacroEvents.Where(s => s.MacroName.Equals(selectedMacroName)).FirstOrDefault();

                    selectedMacro.Events.Remove(selectedMacro.Events.Where(s => s.EventId.Equals(listViewItem.Text)).FirstOrDefault());
                }
                // Update file
                MacroService.SaveMacro(MacroEvents);
            }
        }
    }
}