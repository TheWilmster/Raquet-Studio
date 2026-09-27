using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Raquet_Studio
{
    public partial class ActorEditor : Form
    {
        EventSelector? selector = null;
        public string actorPath;
        RaquetActor actor;
        public ActorEditor(RaquetActor actor, string directory)
        {
            InitializeComponent();
            this.actor = actor;
            actorPath = directory;

            foreach (int ev in actor.events)
            {
                EventType type = (EventType)ev;
                if (ev == -1)
                    continue;

                EventList.Items.Add(EventUtil.EventTypeToName(type));
            }

            FileName.Text = actor.name;
            OriginX.Value = actor.origin.X;
            OriginY.Value = actor.origin.Y;
            AngleInput.Value = actor.angle;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(actor, options);
            File.WriteAllText(actorPath, json);
            SaveStatus.Text = "Saved";
        }

        private void OriginX_ValueChanged(object sender, EventArgs e)
        {
            actor.origin = new Point((int)OriginX.Value, (int)OriginY.Value);
        }

        private void OriginY_ValueChanged(object sender, EventArgs e)
        {
            actor.origin = new Point((int)OriginX.Value, (int)OriginY.Value);
        }

        private void AngleInput_ValueChanged(object sender, EventArgs e)
        {
            actor.angle = (int)AngleInput.Value;
        }

        private void EventList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            if (selector == null) return;

            selector = new(this)
            {
                StartPosition = FormStartPosition.Manual
            };
            new Border98(selector);
        }

        public void AddEventType(EventType type)
        {
            if (actor.events[(uint)type] > -1)
            {
                MessageBox.Show("Dude what the hell do you think you're doing");
                return;
            }
            string eventName = EventUtil.EventTypeToName(type);
            string eventsFolder = Path.Combine(ProjectUtil.currentProjectPath, "src", "Events");
            string filePath = Path.Combine(eventsFolder, string.Concat(actor.name, "_", eventName, ".c"));

            if (!Directory.Exists(eventsFolder))
            {
                Directory.CreateDirectory(eventsFolder);
            }

            int id = ProjectUtil.FillNextDynaFuncSlot(filePath);
            actor.events[(uint)type] = id;

            File.WriteAllText(filePath, String.Concat("#include \"Raquet.h\"\n#include \"Raquet_Studio.h\"\n\nvoid ", string.Concat(actor.name, "_", eventName), "(Raquet_Actor * actor)\n{\n}"));

            EventList.Items.Add(eventName);

            /*if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            File.Create(filePath).Close();*/
        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            string? eventName = EventList.SelectedItem as string;
            if (eventName == null)
            {
                return; //idfk bro
            }
            string eventsFolder = Path.Combine(ProjectUtil.currentProjectPath, "src", "Events");
            string filePath = Path.Combine(eventsFolder, string.Concat(actor.name, "_", eventName, ".c"));

            ScriptEditor editor = new ScriptEditor(String.Concat(actor.name, " ", eventName, " Event"), filePath);
            editor.StartPosition = FormStartPosition.Manual;
            editor.FormBorderStyle = FormBorderStyle.Fixed3D;
            new Border98(editor);
        }
    }

    public enum ActorFlip
    {
        SDL_FLIP_NONE = 0x00000000,     /** Do not flip */
        SDL_FLIP_HORIZONTAL = 0x00000001,    /** flip horizontally */
        SDL_FLIP_VERTICAL = 0x00000002     /** flip vertically */
    }

    public class RaquetCHR // kinda useless rn
    {
        public int width;
        public int height;
        public int data;
        //RaquetPalette palette[4];

        public override string ToString()
        {

            return String.Empty;
        }
    }

    public class RaquetBBox
    {
        public int x1 = 0;
        public int y1 = 0;
        public int x2 = 0;
        public int y2 = 0;

        public RaquetBBox() { }

        public RaquetBBox(int _x1, int _y1, int _x2, int _y2)
        {
            x1 = _x1;
            y1 = _y1;
            x2 = _x2;
            y2 = _y2;
        }
    }
    
    public class RaquetActor
    {
        Point _initialPosition = Point.Empty;
        Point _origin = Point.Empty;
        int _angle = 0;
        ActorFlip _flip = ActorFlip.SDL_FLIP_NONE;
        int _width;
        int _height;
        RaquetBBox? _bbox;
        string _name;
        string _spriteName;
        public int[] _events = new int[(byte)EventType._Length];

        public string resourceVersion { get => "v1.0"; }
        public string name { get => _name; set => _name = value; }
        public Point initialPosition { get => _initialPosition; set => _initialPosition = value; }
        public Point origin { get => _origin; set => _origin = value; }
        public int angle { get => _angle; set => _angle = value; }
        public ActorFlip flip { get => _flip; set => _flip = value; }
        public int width { get => _width; set => _width = value; }
        public int height { get => _height; set => _height = value; }
        public RaquetBBox bbox { get => _bbox; set => _bbox = value; }
        public string spriteName { get => _spriteName; set => _spriteName = value; }
        public int[] events { get => _events; set => _events = value;  }

        public RaquetActor(string name)
        {
            width = 0;
            height = 0;
            bbox = new RaquetBBox(0, 0, 0, 0);
            this.name = name;

            for (int i = 0; i < events.Length; i++)
            {
                events[i] = -1;
            }
        }

        public RaquetActor(string name, string spriteName)
        {
            this.name = name;
            this.spriteName = spriteName;
            bbox = new RaquetBBox(0, 0, 0, 0);
            // width = chr.width
            // height = chr.height

            for (int i = 0; i < events.Length; i++)
            {
                events[i] = -1;
            }
        }

        public RaquetActor(string name, string spriteName, RaquetBBox bbox)
        {
            this.bbox = bbox;
            this.name = name;
            this.spriteName = spriteName;
            // width = chr.width
            // height = chr.height

            for (int i = 0; i < events.Length; i++)
            {
                events[i] = -1;
            }
        }

        [JsonConstructor]
        public RaquetActor(Point initialPosition, Point origin, int angle, ActorFlip flip, int width, int height, RaquetBBox bbox, string spriteName, int[] events)
        {
            this.initialPosition = initialPosition;
            this.origin = origin;
            this.angle = angle;
            this.flip = flip;
            this.width = width;
            this.height = height;
            this.bbox = bbox;
            this.spriteName = spriteName;
            this.events = events;
        }

        public static RaquetActor? Load(string directory)
        {
            if (!File.Exists(directory))
            {
                MessageBox.Show(String.Concat("The file ", directory, " doesn't exist, buddy."));
                return null;
            }
            string json = File.ReadAllText(directory);
            RaquetActor? actor = JsonSerializer.Deserialize<RaquetActor>(json);
            if (actor == null)
            {
                return null; // you could say this if statement is redundant but it's needed for the loop under it to not throw a fucking fit if actor does end up being null
            }
            return actor;
        }

        public byte[] Serialize()
        {
            byte[] actorbytes;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    writer.Write(name);
                    writer.Write((Int32)initialPosition.X);
                    writer.Write((Int32)initialPosition.Y);
                    writer.Write((Int32)origin.X);
                    writer.Write((Int32)origin.Y);
                    writer.Write((UInt16)angle);
                    writer.Write((byte)flip);
                    writer.Write((Int32)width);
                    writer.Write((Int32)height);
                    writer.Write((Int32)bbox.x1);
                    writer.Write((Int32)bbox.y1);
                    writer.Write((Int32)bbox.x2);
                    writer.Write((Int32)bbox.y2);
                }
                actorbytes = stream.ToArray();
            }
            return actorbytes;
        }
    }
}
