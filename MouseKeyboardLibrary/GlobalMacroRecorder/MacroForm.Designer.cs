namespace GlobalMacroRecorder
{
    partial class MacroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroForm));
            this.recordStartButton = new System.Windows.Forms.Button();
            this.recordStopButton = new System.Windows.Forms.Button();
            this.playBackMacroButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Hidewindow = new System.Windows.Forms.CheckBox();
            this.stoponselect = new System.Windows.Forms.CheckBox();
            this.HotkeyActivated = new System.Windows.Forms.CheckBox();
            this.ForeverLoop = new System.Windows.Forms.CheckBox();
            this.savemacro = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMouseMove = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKeyboardEvents = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstMouseEvents = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.curXYLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstSavedMacros = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuKeyboardEvents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuKeyboardEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordStartButton
            // 
            this.recordStartButton.Location = new System.Drawing.Point(124, 15);
            this.recordStartButton.Name = "recordStartButton";
            this.recordStartButton.Size = new System.Drawing.Size(96, 23);
            this.recordStartButton.TabIndex = 0;
            this.recordStartButton.Text = "Start";
            this.recordStartButton.UseVisualStyleBackColor = true;
            this.recordStartButton.Click += new System.EventHandler(this.recordStartButton_Click);
            // 
            // recordStopButton
            // 
            this.recordStopButton.Enabled = false;
            this.recordStopButton.Location = new System.Drawing.Point(223, 15);
            this.recordStopButton.Name = "recordStopButton";
            this.recordStopButton.Size = new System.Drawing.Size(102, 23);
            this.recordStopButton.TabIndex = 0;
            this.recordStopButton.Text = "Stop";
            this.recordStopButton.UseVisualStyleBackColor = true;
            this.recordStopButton.Click += new System.EventHandler(this.recordStopButton_Click);
            // 
            // playBackMacroButton
            // 
            this.playBackMacroButton.Location = new System.Drawing.Point(124, 44);
            this.playBackMacroButton.Name = "playBackMacroButton";
            this.playBackMacroButton.Size = new System.Drawing.Size(201, 25);
            this.playBackMacroButton.TabIndex = 1;
            this.playBackMacroButton.Text = "Play Back";
            this.playBackMacroButton.UseVisualStyleBackColor = true;
            this.playBackMacroButton.Click += new System.EventHandler(this.playBackMacroButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Record Macro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Playback Macro:";
            // 
            // PlayWorker
            // 
            this.PlayWorker.WorkerReportsProgress = true;
            this.PlayWorker.WorkerSupportsCancellation = true;
            this.PlayWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PlayWorker_DoWork);
            this.PlayWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.PlayWorker_ProgressChanged);
            this.PlayWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PlayWorker_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 125);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(326, 12);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // Hidewindow
            // 
            this.Hidewindow.AutoSize = true;
            this.Hidewindow.Location = new System.Drawing.Point(28, 75);
            this.Hidewindow.Name = "Hidewindow";
            this.Hidewindow.Size = new System.Drawing.Size(90, 17);
            this.Hidewindow.TabIndex = 4;
            this.Hidewindow.Text = "Hide Window";
            this.Hidewindow.UseVisualStyleBackColor = true;
            // 
            // stoponselect
            // 
            this.stoponselect.AutoSize = true;
            this.stoponselect.Location = new System.Drawing.Point(124, 75);
            this.stoponselect.Name = "stoponselect";
            this.stoponselect.Size = new System.Drawing.Size(96, 17);
            this.stoponselect.TabIndex = 5;
            this.stoponselect.Text = "Stop on Select";
            this.stoponselect.UseVisualStyleBackColor = true;
            // 
            // HotkeyActivated
            // 
            this.HotkeyActivated.AutoSize = true;
            this.HotkeyActivated.Location = new System.Drawing.Point(223, 75);
            this.HotkeyActivated.Name = "HotkeyActivated";
            this.HotkeyActivated.Size = new System.Drawing.Size(110, 17);
            this.HotkeyActivated.TabIndex = 7;
            this.HotkeyActivated.Text = "Hotkey Activation";
            this.HotkeyActivated.UseVisualStyleBackColor = true;
            this.HotkeyActivated.CheckedChanged += new System.EventHandler(this.HotkeyActivated_CheckedChanged);
            // 
            // ForeverLoop
            // 
            this.ForeverLoop.AutoSize = true;
            this.ForeverLoop.Location = new System.Drawing.Point(223, 98);
            this.ForeverLoop.Name = "ForeverLoop";
            this.ForeverLoop.Size = new System.Drawing.Size(89, 17);
            this.ForeverLoop.TabIndex = 8;
            this.ForeverLoop.Text = "Forever Loop";
            this.ForeverLoop.UseVisualStyleBackColor = true;
            this.ForeverLoop.Visible = false;
            this.ForeverLoop.CheckedChanged += new System.EventHandler(this.ForeverLoop_CheckedChanged);
            // 
            // savemacro
            // 
            this.savemacro.AutoSize = true;
            this.savemacro.Checked = true;
            this.savemacro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.savemacro.Location = new System.Drawing.Point(28, 98);
            this.savemacro.Name = "savemacro";
            this.savemacro.Size = new System.Drawing.Size(83, 17);
            this.savemacro.TabIndex = 9;
            this.savemacro.Text = "Save macro";
            this.savemacro.UseVisualStyleBackColor = true;
            this.savemacro.CheckedChanged += new System.EventHandler(this.savemacro_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkMouseMove);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.savemacro);
            this.panel1.Controls.Add(this.recordStartButton);
            this.panel1.Controls.Add(this.ForeverLoop);
            this.panel1.Controls.Add(this.recordStopButton);
            this.panel1.Controls.Add(this.HotkeyActivated);
            this.panel1.Controls.Add(this.playBackMacroButton);
            this.panel1.Controls.Add(this.stoponselect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Hidewindow);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 145);
            this.panel1.TabIndex = 10;
            // 
            // chkMouseMove
            // 
            this.chkMouseMove.AutoSize = true;
            this.chkMouseMove.Location = new System.Drawing.Point(124, 98);
            this.chkMouseMove.Name = "chkMouseMove";
            this.chkMouseMove.Size = new System.Drawing.Size(88, 17);
            this.chkMouseMove.TabIndex = 10;
            this.chkMouseMove.Text = "Mouse Move";
            this.chkMouseMove.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKeyboardEvents);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keyboard";
            // 
            // lstKeyboardEvents
            // 
            this.lstKeyboardEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader6,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader17});
            this.lstKeyboardEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKeyboardEvents.FullRowSelect = true;
            this.lstKeyboardEvents.Location = new System.Drawing.Point(3, 16);
            this.lstKeyboardEvents.Name = "lstKeyboardEvents";
            this.lstKeyboardEvents.Size = new System.Drawing.Size(324, 117);
            this.lstKeyboardEvents.TabIndex = 1;
            this.lstKeyboardEvents.UseCompatibleStateImageBehavior = false;
            this.lstKeyboardEvents.View = System.Windows.Forms.View.Details;
            this.lstKeyboardEvents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstKeyboardEvents_KeyDown);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "EventType";
            this.columnHeader6.Width = 109;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "KeyCode";
            this.columnHeader11.Width = 73;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "KeyChar";
            this.columnHeader12.Width = 52;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Shift";
            this.columnHeader13.Width = 44;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Alt";
            this.columnHeader14.Width = 41;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Control";
            this.columnHeader15.Width = 56;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Window";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstMouseEvents);
            this.groupBox1.Controls.Add(this.curXYLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse";
            // 
            // lstMouseEvents
            // 
            this.lstMouseEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lstMouseEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMouseEvents.FullRowSelect = true;
            this.lstMouseEvents.Location = new System.Drawing.Point(3, 16);
            this.lstMouseEvents.Name = "lstMouseEvents";
            this.lstMouseEvents.Size = new System.Drawing.Size(324, 118);
            this.lstMouseEvents.TabIndex = 1;
            this.lstMouseEvents.UseCompatibleStateImageBehavior = false;
            this.lstMouseEvents.View = System.Windows.Forms.View.Details;
            this.lstMouseEvents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMouseEvents_KeyDown);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EventType";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Button";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "X";
            this.columnHeader2.Width = 46;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Y";
            this.columnHeader3.Width = 48;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Delta";
            this.columnHeader5.Width = 83;
            // 
            // curXYLabel
            // 
            this.curXYLabel.AutoSize = true;
            this.curXYLabel.Location = new System.Drawing.Point(22, 22);
            this.curXYLabel.Name = "curXYLabel";
            this.curXYLabel.Size = new System.Drawing.Size(0, 13);
            this.curXYLabel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 285);
            this.panel3.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstSavedMacros);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 140);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saved macros";
            // 
            // lstSavedMacros
            // 
            this.lstSavedMacros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstSavedMacros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSavedMacros.FullRowSelect = true;
            this.lstSavedMacros.Location = new System.Drawing.Point(3, 16);
            this.lstSavedMacros.Name = "lstSavedMacros";
            this.lstSavedMacros.Size = new System.Drawing.Size(344, 121);
            this.lstSavedMacros.TabIndex = 0;
            this.lstSavedMacros.UseCompatibleStateImageBehavior = false;
            this.lstSavedMacros.View = System.Windows.Forms.View.Details;
            this.lstSavedMacros.SelectedIndexChanged += new System.EventHandler(this.lstSavedMacros_SelectedIndexChanged);
            this.lstSavedMacros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSavedMacros_KeyDown);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Macro Name";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Description";
            this.columnHeader8.Width = 135;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Created On";
            this.columnHeader9.Width = 111;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 285);
            this.panel4.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(350, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 285);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 285);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(686, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuKeyboardEvents
            // 
            this.contextMenuKeyboardEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuKeyboardEvents.Name = "contextMenuKeyboardEvents";
            this.contextMenuKeyboardEvents.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // MacroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MacroForm";
            this.Text = "Global Macro Recorder Example";
            this.Click += new System.EventHandler(this.MacroForm_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MacroForm_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuKeyboardEvents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recordStartButton;
        private System.Windows.Forms.Button recordStopButton;
        private System.Windows.Forms.Button playBackMacroButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker PlayWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox Hidewindow;
        private System.Windows.Forms.CheckBox stoponselect;
        private System.Windows.Forms.CheckBox HotkeyActivated;
        private System.Windows.Forms.CheckBox ForeverLoop;
        private System.Windows.Forms.CheckBox savemacro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstKeyboardEvents;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstMouseEvents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label curXYLabel;
        private System.Windows.Forms.ListView lstSavedMacros;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.CheckBox chkMouseMove;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ContextMenuStrip contextMenuKeyboardEvents;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

