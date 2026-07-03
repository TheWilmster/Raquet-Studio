using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Raquet_Studio
{
    public partial class ProjectForm : Form
    {
        public string ConsoleOutput = String.Empty;
        public string ConsoleError = String.Empty;
        public Process? ConsoleProcess;

        public ProjectForm()
        {
            InitializeComponent();
        }

        private async Task ScriptButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string? path = ProjectUtil.scriptPaths.GetValueOrDefault(button.Text, null);
            if (path == null)
            {
                MessageBox.Show(String.Concat("Failure attempting to open script \"", button.Text, "\""));
                return;
            }

            /*RichTextBox textEditor = new RichTextBox();
            textEditor.Name = String.Concat("Editor_", button.Name);
            textEditor.Text = File.ReadAllText(path);
            textEditor.Parent = this;
            textEditor.Show();*/

            ScriptEditor editor = new ScriptEditor(button.Text, path);
            editor.StartPosition = FormStartPosition.Manual;
            editor.Show();

            //panel1.Controls.Add(editor);
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Scripts";
            ScriptList.Controls.Add(label);

            string sourcePath = Path.Combine(ProjectUtil.currentProjectPath, "src");
            string[] scripts = Directory.GetFiles(sourcePath);
            for (int i = 0; i < scripts.Length; i++)
            {
                Button scrButton = new Button();
                string scriptName = Path.GetFileName(scripts[i]);
                scrButton.Name = scriptName.Replace(" ", "_");
                scrButton.Text = scriptName;
                scrButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                ProjectUtil.scriptPaths.Add(scriptName, scripts[i]);

                scrButton.Click += delegate { ScriptButton_Click(scrButton, new EventArgs()); };

                ScriptList.Controls.Add(scrButton);
            }

            for (int i = 0; i < this.MdiChildren.Length; i++)
            {

            }
            
            //Console
        }

        void Compile(bool clean = false)
        {
            ConsoleProcess = new Process();
            ConsoleProcess.StartInfo = new ProcessStartInfo
            {
                FileName = @"C:\msys64\mingw64.exe",
                Arguments = "make" + (clean ? " clean" : ""),
                WorkingDirectory = ProjectUtil.currentProjectPath,
                UseShellExecute = false,
            };
            ConsoleProcess.Start();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Compile();
        }

        private void CleanRunButton_Click(object sender, EventArgs e)
        {
            ConsoleProcess.StandardInput.WriteLine("exit");
            ConsoleProcess.StandardInput.Flush();

        }
    }
}
