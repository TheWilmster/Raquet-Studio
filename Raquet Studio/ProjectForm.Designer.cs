using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Raquet_Studio
{
    partial class ProjectForm
    {

        private System.ComponentModel.IContainer components = null;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            pictureBox2 = new PictureBox();
            RunButton = new Button();
            CleanRunButton = new Button();
            BottomTabs = new TabControl();
            Output = new TabPage();
            OutputText = new Label();
            Error = new TabPage();
            ErrorText = new Label();
            HomeButton = new Button();
            RightTabs = new TabControl();
            ScriptsPage = new TabPage();
            ScriptsList = new TableLayoutPanel();
            AssetsPage = new TabPage();
            AssetsList = new TableLayoutPanel();
            ActorsPage = new TabPage();
            ActorsList = new TableLayoutPanel();
            ScenesPage = new TabPage();
            ScenesList = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            BottomTabs.SuspendLayout();
            Output.SuspendLayout();
            Error.SuspendLayout();
            RightTabs.SuspendLayout();
            ScriptsPage.SuspendLayout();
            AssetsPage.SuspendLayout();
            ActorsPage.SuspendLayout();
            ScenesPage.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1280, 128);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // RunButton
            // 
            RunButton.AccessibleDescription = "Compile and run.";
            RunButton.AccessibleName = "Run";
            RunButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
            RunButton.Location = new Point(34, 11);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(58, 24);
            RunButton.TabIndex = 7;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // CleanRunButton
            // 
            CleanRunButton.AccessibleDescription = "Completely recompile and run the game.";
            CleanRunButton.AccessibleName = "Clean Run";
            CleanRunButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
            CleanRunButton.Location = new Point(98, 11);
            CleanRunButton.Name = "CleanRunButton";
            CleanRunButton.Size = new Size(123, 24);
            CleanRunButton.TabIndex = 8;
            CleanRunButton.Text = "Clean Run";
            CleanRunButton.UseVisualStyleBackColor = true;
            CleanRunButton.Click += CleanRunButton_Click;
            // 
            // BottomTabs
            // 
            BottomTabs.Controls.Add(Output);
            BottomTabs.Controls.Add(Error);
            BottomTabs.Dock = DockStyle.Bottom;
            BottomTabs.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BottomTabs.Location = new Point(0, 553);
            BottomTabs.Name = "BottomTabs";
            BottomTabs.SelectedIndex = 0;
            BottomTabs.Size = new Size(1044, 128);
            BottomTabs.TabIndex = 9;
            // 
            // Output
            // 
            Output.BackColor = Color.FromArgb(49, 0, 57);
            Output.Controls.Add(OutputText);
            Output.ForeColor = SystemColors.ControlLightLight;
            Output.Location = new Point(4, 22);
            Output.Name = "Output";
            Output.Padding = new Padding(3);
            Output.Size = new Size(1036, 102);
            Output.TabIndex = 0;
            Output.Text = "Output";
            // 
            // OutputText
            // 
            OutputText.AutoSize = true;
            OutputText.Dock = DockStyle.Fill;
            OutputText.Location = new Point(3, 3);
            OutputText.MaximumSize = new Size(1258, 0);
            OutputText.MinimumSize = new Size(8, 0);
            OutputText.Name = "OutputText";
            OutputText.Size = new Size(8, 12);
            OutputText.TabIndex = 1;
            // 
            // Error
            // 
            Error.BackColor = Color.FromArgb(49, 0, 57);
            Error.Controls.Add(ErrorText);
            Error.ForeColor = SystemColors.ControlLightLight;
            Error.Location = new Point(4, 22);
            Error.Name = "Error";
            Error.Padding = new Padding(3);
            Error.Size = new Size(1036, 102);
            Error.TabIndex = 1;
            Error.Text = "Error";
            // 
            // ErrorText
            // 
            ErrorText.AutoSize = true;
            ErrorText.Dock = DockStyle.Fill;
            ErrorText.Location = new Point(3, 3);
            ErrorText.MaximumSize = new Size(1258, 0);
            ErrorText.MinimumSize = new Size(8, 0);
            ErrorText.Name = "ErrorText";
            ErrorText.Size = new Size(8, 12);
            ErrorText.TabIndex = 0;
            // 
            // HomeButton
            // 
            HomeButton.AccessibleDescription = "Go back to the project menu.";
            HomeButton.AccessibleName = "Back";
            HomeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeButton.Location = new Point(4, 11);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(24, 24);
            HomeButton.TabIndex = 10;
            HomeButton.Text = "<";
            HomeButton.UseVisualStyleBackColor = true;
            // 
            // RightTabs
            // 
            RightTabs.Controls.Add(ScriptsPage);
            RightTabs.Controls.Add(AssetsPage);
            RightTabs.Controls.Add(ActorsPage);
            RightTabs.Controls.Add(ScenesPage);
            RightTabs.Dock = DockStyle.Right;
            RightTabs.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RightTabs.Location = new Point(1044, 0);
            RightTabs.Name = "RightTabs";
            RightTabs.Padding = new Point(3, 3);
            RightTabs.SelectedIndex = 0;
            RightTabs.Size = new Size(220, 681);
            RightTabs.TabIndex = 11;
            // 
            // ScriptsPage
            // 
            ScriptsPage.BackColor = Color.Purple;
            ScriptsPage.Controls.Add(ScriptsList);
            ScriptsPage.Location = new Point(4, 22);
            ScriptsPage.Margin = new Padding(0);
            ScriptsPage.Name = "ScriptsPage";
            ScriptsPage.Padding = new Padding(3);
            ScriptsPage.Size = new Size(212, 655);
            ScriptsPage.TabIndex = 0;
            ScriptsPage.Text = "Scripts";
            // 
            // ScriptsList
            // 
            ScriptsList.BackColor = Color.Purple;
            ScriptsList.ColumnCount = 1;
            ScriptsList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ScriptsList.Dock = DockStyle.Fill;
            ScriptsList.Location = new Point(3, 3);
            ScriptsList.Margin = new Padding(0);
            ScriptsList.Name = "ScriptsList";
            ScriptsList.RowCount = 1;
            ScriptsList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ScriptsList.Size = new Size(206, 649);
            ScriptsList.TabIndex = 0;
            // 
            // AssetsPage
            // 
            AssetsPage.BackColor = Color.Purple;
            AssetsPage.Controls.Add(AssetsList);
            AssetsPage.Location = new Point(4, 22);
            AssetsPage.Margin = new Padding(0);
            AssetsPage.Name = "AssetsPage";
            AssetsPage.Padding = new Padding(3);
            AssetsPage.Size = new Size(212, 655);
            AssetsPage.TabIndex = 1;
            AssetsPage.Text = "Assets";
            // 
            // AssetsList
            // 
            AssetsList.BackColor = Color.Purple;
            AssetsList.ColumnCount = 1;
            AssetsList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AssetsList.Dock = DockStyle.Fill;
            AssetsList.Location = new Point(3, 3);
            AssetsList.Margin = new Padding(0);
            AssetsList.Name = "AssetsList";
            AssetsList.RowCount = 1;
            AssetsList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AssetsList.Size = new Size(206, 649);
            AssetsList.TabIndex = 0;
            // 
            // ActorsPage
            // 
            ActorsPage.BackColor = Color.Purple;
            ActorsPage.Controls.Add(ActorsList);
            ActorsPage.Location = new Point(4, 22);
            ActorsPage.Name = "ActorsPage";
            ActorsPage.Padding = new Padding(3);
            ActorsPage.Size = new Size(212, 655);
            ActorsPage.TabIndex = 2;
            ActorsPage.Text = "Actors";
            // 
            // ActorsList
            // 
            ActorsList.BackColor = Color.Purple;
            ActorsList.ColumnCount = 1;
            ActorsList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ActorsList.Dock = DockStyle.Fill;
            ActorsList.Location = new Point(3, 3);
            ActorsList.Margin = new Padding(0);
            ActorsList.Name = "ActorsList";
            ActorsList.RowCount = 1;
            ActorsList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ActorsList.Size = new Size(206, 649);
            ActorsList.TabIndex = 1;
            // 
            // ScenesPage
            // 
            ScenesPage.BackColor = Color.Purple;
            ScenesPage.Controls.Add(ScenesList);
            ScenesPage.Location = new Point(4, 22);
            ScenesPage.Name = "ScenesPage";
            ScenesPage.Padding = new Padding(3);
            ScenesPage.Size = new Size(212, 655);
            ScenesPage.TabIndex = 3;
            ScenesPage.Text = "Scenes";
            // 
            // ScenesList
            // 
            ScenesList.BackColor = Color.Purple;
            ScenesList.ColumnCount = 1;
            ScenesList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ScenesList.Dock = DockStyle.Fill;
            ScenesList.Location = new Point(3, 3);
            ScenesList.Margin = new Padding(0);
            ScenesList.Name = "ScenesList";
            ScenesList.RowCount = 1;
            ScenesList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ScenesList.Size = new Size(206, 649);
            ScenesList.TabIndex = 1;
            // 
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 209, 255);
            ClientSize = new Size(1264, 681);
            Controls.Add(HomeButton);
            Controls.Add(BottomTabs);
            Controls.Add(CleanRunButton);
            Controls.Add(RunButton);
            Controls.Add(RightTabs);
            Controls.Add(pictureBox2);
            Name = "ProjectForm";
            Text = "ProjectForm";
            Load += ProjectForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            BottomTabs.ResumeLayout(false);
            Output.ResumeLayout(false);
            Output.PerformLayout();
            Error.ResumeLayout(false);
            Error.PerformLayout();
            RightTabs.ResumeLayout(false);
            ScriptsPage.ResumeLayout(false);
            AssetsPage.ResumeLayout(false);
            ActorsPage.ResumeLayout(false);
            ScenesPage.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private PictureBox pictureBox2;
        private Button RunButton;
        private Button CleanRunButton;
        private TabControl BottomTabs;
        private TabPage Output;
        private TabPage Error;
        private Button HomeButton;
        private Label ErrorText;
        private Label OutputText;
        private TabControl RightTabs;
        private TabPage ScriptsPage;
        private TableLayoutPanel ScriptsList;
        private TabPage AssetsPage;
        private TableLayoutPanel AssetsList;
        private TabPage ActorsPage;
        private TableLayoutPanel ActorsList;
        private TabPage ScenesPage;
        private TableLayoutPanel ScenesList;
    }
}
