using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static Microsoft.VisualBasic.Interaction;

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

            ScriptEditor editor = new(button.Text, path);
            editor.StartPosition = FormStartPosition.Manual;
            editor.FormBorderStyle = FormBorderStyle.Fixed3D;
            Border98 border = new(editor);
        }

        void AssetButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string? path = ProjectUtil.actorPaths.GetValueOrDefault(button.Text, null);

            //Process.Start(path);
        }

        void ActorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string? path = ProjectUtil.actorPaths.GetValueOrDefault(button.Text, null);
            if (path == null)
            {
                MessageBox.Show(String.Concat("Failure attempting to open actor \"", button.Text, "\""));
                return;
            }

            RaquetActor? actor = RaquetActor.Load(path);
            if (actor == null)
            {
                MessageBox.Show(String.Concat("Failure attempting to open actor \"", button.Text, "\""));
                return;
            }

            ActorEditor editor = new ActorEditor(actor, path);
            editor.StartPosition = FormStartPosition.Manual;
            editor.FormBorderStyle = FormBorderStyle.Fixed3D;
            new Border98(editor);
        }

        void AddActorButton_Click(object sender, EventArgs e)
        {
            string extension = ".json";
            bool validName = false;
            string name = String.Empty;
            while (!validName)
            {
                name = InputBox("What would you like the name of this actor to be?", "Raquet Studio");

                if (name.Length + extension.Length >= 256)
                {
                    MessageBox.Show(String.Concat("Actor name must be under ", 256 - extension.Length, " characters long."));
                    continue;
                }

                if (name.Contains('<') || name.Contains('>') || name.Contains(':') || name.Contains('\'') || name.Contains('/') || name.Contains('\\') || name.Contains('|') || name.Contains('?') || name.Contains('*'))
                {
                    MessageBox.Show("Actor name cannot contain, <, >, :, \", /, \\, |, ?, or *");
                    continue;
                }

                validName = true;
            }

            ProjectUtil.CheckStudioAssetsFolder();

            string actorsPath = Path.Combine(ProjectUtil.studioAssetsFolder, "Actors");
            //Process.Start("explorer.exe", actorsPath);
            RaquetActor actor = new RaquetActor(name);
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string serializedActor = JsonSerializer.Serialize(actor, options);

            string actorPath = Path.Combine(actorsPath, name);
            string filePath = Path.Combine(actorPath, "actor" + extension);
            if (!Directory.Exists(actorPath))
            { 
                Directory.CreateDirectory(actorPath);
            }
            else if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show("This actor already exists. Would you like to overwrite it?", "Raquet Studio", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            File.WriteAllText(filePath, serializedActor);

            RefreshActorList();
        }

        Button CreateAssetButton(string name, bool isPPF)
        {
            Button scrButton = new Button()
            {
                Name = name,
                Font = new Font(RightTabs.Font.FontFamily, 12),
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right,
                FlatStyle = FlatStyle.Flat,
                Width = ScriptsList.Width,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.White,
                Margin = new Padding(0)
            };
            if (isPPF)
            {
                scrButton.Click += PpfButton_Click;
            }
            scrButton.FlatAppearance.CheckedBackColor = Color.Cyan;
            scrButton.FlatAppearance.BorderSize = 0;

            return scrButton;
        }

        void PpfButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string ppfPath = ProjectUtil.scriptPaths[button.Name];
            //MessageBox.Show(ppfPath);
            List<byte[]>? ppfData = ProjectUtil.LoadPPF(ppfPath);
            if (ppfData == null) { MessageBox.Show("Failed to load PPF file."); return; }

            PPFEditor editor = new PPFEditor(ppfData);
            new Border98(editor);
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            string sourcePath = Path.Combine(ProjectUtil.currentProjectPath, "src");
            string[] scripts = Directory.GetFiles(sourcePath);
            for (int i = 0; i < scripts.Length; i++)
            {
                string scriptName = Path.GetFileName(scripts[i]);
                Button scrButton = CreateAssetButton(scriptName.Replace(" ", "_"), false);
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
                //MessageBox.Show(assetName);
                //MessageBox.Show(assetName.EndsWith(".ppf").ToString());
                Button assButton = CreateAssetButton(assetName.Replace(" ", "_"), assetName.EndsWith(".ppf"));
                assButton.Text = assetName;
                assButton.AccessibleName = assetName;
                assButton.AccessibleDescription = "Asset";
                assButton.Click += AssetButton_Click;
                ProjectUtil.scriptPaths.Add(assetName, assets[i]);

                AssetsList.Controls.Add(assButton);
            }

            RefreshActorList();
        }

        void RefreshActorList()
        {
            ActorsList.Controls.Clear();

            Button addActorButton = CreateAssetButton("CreateActorButton", false);
            addActorButton.Text = "Create Actor";
            addActorButton.Click += AddActorButton_Click;

            ActorsList.Controls.Add(addActorButton);

            string actorsPath = Path.Combine(ProjectUtil.studioAssetsFolder, "Actors");
            ProjectUtil.CheckStudioAssetsFolder();
            string[] actors = Directory.GetDirectories(actorsPath);
            foreach (string actor in actors)
            {
                string[] jsons = Directory.GetFiles(actor);
                foreach (string json in jsons)
                {
                    string actorName = Path.GetFileName(json);
                    Button actButton = CreateAssetButton(actorName.Replace(" ", "_"), false);
                    actButton.Text = actorName;
                    actButton.AccessibleName = actorName;
                    actButton.AccessibleDescription = "Actor";
                    actButton.Click += ActorButton_Click;
                    ProjectUtil.actorPaths.Add(actorName, json);

                    ActorsList.Controls.Add(actButton);
                }
            }
        }

        public void Print(params string[] pussy)
        {
            foreach (string egg in pussy)
            {
                ConsoleOutput += egg;
            }
            OutputText.Text = ConsoleOutput;
        }

        public void PrintError(params string[] pussy)
        {
            foreach (string egg in pussy)
            {
                ConsoleError += egg;
            }
            ErrorText.Text = ConsoleError;
            BottomTabs.SelectedIndex = 1;
            BottomTabs.TabIndex = 1;
        }

        void Compile(bool clean = false, bool verbose = true)
        {
            Print("Creating assets.raqbin data...\nGenerating header chunk...\n");
            List<byte> studioData = [];

            char[] header = "RAQSTUDIO".ToCharArray();
            foreach (char c in header)
            {
                studioData.Add(Convert.ToByte(c));
            }

            studioData.Add(0); //bytecode version
             /*
             * 0 ---- pre-release
             * 1 ---- v1.0
             */
            

            Print("Generating chunk ACT...\n");
            studioData.Add(Convert.ToByte('A'));
            studioData.Add(Convert.ToByte('C'));
            studioData.Add(Convert.ToByte('T'));
            studioData.Add((byte)ProjectUtil.actorPaths.Count);
            foreach (KeyValuePair<string,string> pair in ProjectUtil.actorPaths)
            {
                RaquetActor? actor = RaquetActor.Load(pair.Value);
                MessageBox.Show(string.Concat(pair.Key, ", ", pair.Value));
                if (actor == null)
                {
                    PrintError("Error! Couldn't find actor file for ", pair.Key, ". Aborting...");
                    BottomTabs.TabIndex = 1;

                    OutputText.Text = ConsoleOutput;
                    ErrorText.Text = ConsoleError;
                    return;
                }

                if (verbose) Print("Serializing ", actor.name, "... ");

                byte[] actorData = actor.Serialize();
                //MessageBox.Show(string.Join(", ", actorData));
                studioData.AddRange(actorData);

                

                /*try
                {
                    byte[] actorData = actor.Serialize();
                    MessageBox.Show(string.Join(", ", actorData));
                    studioData.AddRange(actorData);
                }
                catch
                {
                    if (verbose) ConsoleOutput += string.Concat("Failed. Aborting...");
                    else
                    {
                        ConsoleError += string.Concat("Error! Couldn't serialize actor ", actor.name, ". Aborting...");

                        OutputText.Text = ConsoleOutput;
                        ErrorText.Text = ConsoleError;

                        BottomTabs.TabIndex = 1;
                        return;
                    }

                    OutputText.Text = ConsoleOutput;
                    ErrorText.Text = ConsoleError;

                    return;
                }*/

                if (verbose) Print("Success!\n");

            }

            string assetsPath = Path.Combine(ProjectUtil.currentProjectPath, "assets", "assets.raqbin");
            if (!File.Exists(assetsPath))
            {
                File.Create(assetsPath).Close();
            }
            File.WriteAllBytes(assetsPath, studioData.ToArray());

            ConsoleProcess = new()
            {
                StartInfo = new()
                {
                    FileName = @"C:\msys64\mingw64.exe",
                    Arguments = "make" + (clean ? " clean" : ""),
                    WorkingDirectory = ProjectUtil.currentProjectPath,
                    UseShellExecute = false,
                }
            };
            ConsoleProcess.Start();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Compile();
        }

        private void CleanRunButton_Click(object sender, EventArgs e)
        {
            Compile(true);
        }
    }
}
