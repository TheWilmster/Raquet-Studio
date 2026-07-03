using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Raquet_Studio
{
    public partial class ScriptEditor : Form
    {
        public string scriptPath;
        public string scriptName;

        public ScriptEditor(string name, string path)
        {
            InitializeComponent();
            scriptName = name;
            scriptPath = path;
        }

        private void ScriptEditor_Load(object sender, EventArgs e)
        {
            FileName.Text = scriptName;
            TextField.Text = File.ReadAllText(scriptPath);
            SaveStatus.Text = "Unsaved";
            RefreshLineNumbers();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(scriptPath, TextField.Text);
            SaveStatus.Text = "Saved";
        }

        private void TextField_TextChanged(object sender, EventArgs e)
        {
            RefreshLineNumbers();
        }

        void RefreshLineNumbers()
        {
            TextField.Refresh();

            Graphics graph = TextField.CreateGraphics();
            for (int i = 0; i < TextField.Lines.Length; i++)
            {
                float left = TextField.Location.X;
                float top = TextField.Location.Y + (float)(i * 12);

                PointF pos = new PointF(left, top);
                Brush brush = new SolidBrush(Color.Black);

                graph.DrawString(i.ToString(), TextField.Font, brush, pos);
            }
        }
    }
}
