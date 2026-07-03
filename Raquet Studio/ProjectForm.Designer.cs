namespace Raquet_Studio
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            pictureBox2 = new PictureBox();
            ScriptList = new FlowLayoutPanel();
            RunButton = new Button();
            CleanRunButton = new Button();
            BottomTabs = new TabControl();
            Output = new TabPage();
            OutputText = new Label();
            Error = new TabPage();
            ErrorText = new Label();
            HomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            BottomTabs.SuspendLayout();
            Output.SuspendLayout();
            Error.SuspendLayout();
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
            // ScriptList
            // 
            ScriptList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ScriptList.BackColor = Color.FromArgb(159, 136, 166);
            ScriptList.BorderStyle = BorderStyle.Fixed3D;
            ScriptList.FlowDirection = FlowDirection.TopDown;
            ScriptList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
            ScriptList.ForeColor = Color.Purple;
            ScriptList.Location = new Point(4, 41);
            ScriptList.Name = "ScriptList";
            ScriptList.Size = new Size(124, 521);
            ScriptList.TabIndex = 6;
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
            BottomTabs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BottomTabs.Controls.Add(Output);
            BottomTabs.Controls.Add(Error);
            BottomTabs.Location = new Point(0, 568);
            BottomTabs.Name = "BottomTabs";
            BottomTabs.SelectedIndex = 0;
            BottomTabs.Size = new Size(1266, 113);
            BottomTabs.TabIndex = 9;
            // 
            // Output
            // 
            Output.BackColor = Color.FromArgb(49, 0, 57);
            Output.Controls.Add(OutputText);
            Output.ForeColor = SystemColors.ControlLightLight;
            Output.Location = new Point(4, 24);
            Output.Name = "Output";
            Output.Padding = new Padding(3);
            Output.Size = new Size(1258, 85);
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
            OutputText.Size = new Size(8, 15);
            OutputText.TabIndex = 1;
            // 
            // Error
            // 
            Error.BackColor = Color.FromArgb(49, 0, 57);
            Error.Controls.Add(ErrorText);
            Error.ForeColor = SystemColors.ControlLightLight;
            Error.Location = new Point(4, 24);
            Error.Name = "Error";
            Error.Padding = new Padding(3);
            Error.Size = new Size(1258, 85);
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
            ErrorText.Size = new Size(8, 15);
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
            Controls.Add(ScriptList);
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
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private FlowLayoutPanel ScriptList;
        private Button RunButton;
        private Button CleanRunButton;
        private TabControl BottomTabs;
        private TabPage Output;
        private TabPage Error;
        private Button HomeButton;
        private Label ErrorText;
        private Label OutputText;
    }
}