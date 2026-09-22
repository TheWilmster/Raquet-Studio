using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Raquet_Studio
{
    public partial class EventSelector : Form
    {
        ActorEditor editor;

        public EventSelector(ActorEditor editor)
        {
            InitializeComponent();
            for (int i = 0; i < (int)EventType._Length; i++)
            {
                EventType type = (EventType)i;
                EventList.Items.Add(EventUtil.EventTypeToName(type));
            }

            this.editor = editor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (EventList.SelectedIndex != -1)
            {
                editor.AddEventType(EventUtil.EventNameToType((string)EventList.Items[EventList.SelectedIndex]));
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public enum EventType
    {
        None = -1,
        Create = 0,
        Step,
        Draw,
        _Length
    }

    public class EventUtil
    {
        private static Dictionary<EventType, string> EventNames = new() {
            { EventType.Create, "Create" },
            { EventType.Step, "Step"},
            { EventType.Draw, "Draw" }
        };

        public static string EventTypeToName(EventType type)
        {
            return EventNames.GetValueOrDefault(type, string.Empty);
        }

        public static EventType EventNameToType(string name)
        {
            EventType[] types = EventNames.Keys.ToArray();
            string[] names = EventNames.Values.ToArray();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return types[i];
                }
            }
            return EventType.None;
        }
    }
}
