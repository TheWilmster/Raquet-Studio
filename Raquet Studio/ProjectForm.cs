using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

        void ScriptButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string? path = ProjectUtil.scriptPaths.GetValueOrDefault(button.Text, null);
            if (path == null)
            {
                MessageBox.Show(String.Concat("Failure attempting to open script \"", button.Text, "\""));
                return;
            }

            ScriptEditor editor = new ScriptEditor(button.Text, path);
            editor.StartPosition = FormStartPosition.Manual;
            editor.Show();
        }

        void AssetButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string? path = ProjectUtil.scriptPaths.GetValueOrDefault(button.Text, null);

            //Process.Start(path);
        }

        Button CreateAssetButton(string name)
        {
            Button scrButton = new Button();
            scrButton.Name = name;
            scrButton.Font = new Font(RightTabs.Font.FontFamily, 12);
            scrButton.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            scrButton.FlatStyle = FlatStyle.Flat;
            scrButton.FlatAppearance.CheckedBackColor = Color.Cyan;
            scrButton.Width = ScriptsList.Width;
            scrButton.FlatAppearance.BorderSize = 0;
            scrButton.TextAlign = ContentAlignment.MiddleRight;
            scrButton.ForeColor = Color.White;
            scrButton.Margin = new Padding(0);
            return scrButton;
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            string sourcePath = Path.Combine(ProjectUtil.currentProjectPath, "src");
            string[] scripts = Directory.GetFiles(sourcePath);
            for (int i = 0; i < scripts.Length; i++)
            {
                string scriptName = Path.GetFileName(scripts[i]);
                Button scrButton = CreateAssetButton(scriptName.Replace(" ", "_"));
                scrButton.Text = scriptName;
                scrButton.AccessibleName = scriptName;
                scrButton.AccessibleDescription = "C Script";
                scrButton.Click += ScriptButton_Click;
                ProjectUtil.scriptPaths.Add(scriptName, scripts[i]);

                ScriptsList.Controls.Add(scrButton);
            }

            string assetsPath = Path.Combine(ProjectUtil.currentProjectPath, "assets");
            string[] assets = Directory.GetFiles(assetsPath);
            for (int i = 0; i < assets.Length; i++)
            {
                string assetName = Path.GetFileName(assets[i]);
                Button assButton = CreateAssetButton(assetName.Replace(" ", "_"));
                assButton.Text = assetName;
                assButton.AccessibleName = assetName;
                assButton.AccessibleDescription = "Asset";
                assButton.Click += AssetButton_Click;
                ProjectUtil.scriptPaths.Add(assetName, assets[i]);

                AssetsList.Controls.Add(assButton);
            }

            ActorEditor poo = new ActorEditor();
            poo.StartPosition = FormStartPosition.CenterParent;
            poo.Show();
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
