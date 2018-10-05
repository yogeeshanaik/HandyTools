using GlobalMacroRecorder.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace GlobalMacroRecorder
{

    /// <summary>
    /// All possible events that macro can record
    /// </summary>
    [Serializable]
    public enum MacroEventType
    {
        MouseMove,
        MouseDown,
        MouseUp,
        MouseWheel,
        KeyDown,
        KeyUp
    }

    /// <summary>
    /// Series of events that can be recorded any played back
    /// </summary>
    [Serializable]
    public class MacroEvent
    {
        private static long lastTimeStamp = DateTime.UtcNow.Ticks;
        public static long UtcNowTicks
        {
            get
            {
                long original, newValue;
                do
                {
                    original = lastTimeStamp;
                    long now = DateTime.UtcNow.Ticks;
                    newValue = Math.Max(now, original + 1);
                } while (System.Threading.Interlocked.CompareExchange
                             (ref lastTimeStamp, newValue, original) != original);

                return newValue;
            }

        }
        public string EventId;

        public MacroEventType MacroEventType;

        public SerializableMouseEventArgs MouseEventArgs;
        public SerializableKeyEventArgs KeyEventArgs;

        public int TimeSinceLastEvent;

        public string CurrentProcessName;
        public ProcessHelper.Rect WindowSize;

        /*public List<MacroEvent> events = new List<MacroEvent>();
        public List<MacroEvent> Events
        {
            get { return events; }
            set { events = value; }
        }*/

        private MacroEvent()
        {
        }

        public MacroEvent(MacroEventType macroEventType, SerializableMouseEventArgs eventArgs, int timeSinceLastEvent)
        {
            MacroEventType = macroEventType;
            MouseEventArgs = eventArgs;
            TimeSinceLastEvent = timeSinceLastEvent;

            EventId = UtcNowTicks.ToString();

            CurrentProcessName = ProcessHelper.GetForegroundProcessName();
            WindowSize = ProcessHelper.GetWindowRect();
        }

        public MacroEvent(MacroEventType macroEventType, SerializableKeyEventArgs eventArgs, int timeSinceLastEvent)
        {
            MacroEventType = macroEventType;
            KeyEventArgs = eventArgs;
            TimeSinceLastEvent = timeSinceLastEvent;

            EventId = UtcNowTicks.ToString();

            CurrentProcessName = ProcessHelper.GetForegroundProcessName();
            WindowSize = ProcessHelper.GetWindowRect();
        }
    }

    [Serializable]
    public class MacroCollection
    {
        public string MacroName { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public List<MacroEvent> Events { get; set; }
    }
}
