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
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(scriptPath, TextField.Text);
            SaveStatus.Text = "Saved";
        }
    }
}
