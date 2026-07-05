namespace Raquet_Studio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            NewProject = new Button();
            LoadProject = new Button();
            pictureBox2 = new PictureBox();
            Website = new Button();
            ProjectNameInput = new TextBox();
            ConsoleButton = new Button();
            ConsolePathInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(396, 166);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // NewProject
            // 
            NewProject.BackColor = Color.FromArgb(159, 136, 166);
            NewProject.FlatStyle = FlatStyle.Popup;
            NewProject.Font = new Font("SimSun", 12F);
            NewProject.Location = new Point(12, 184);
            NewProject.Name = "NewProject";
            NewProject.Size = new Size(180, 24);
            NewProject.TabIndex = 1;
            NewProject.Text = "New Project";
            NewProject.UseVisualStyleBackColor = false;
            NewProject.Click += NewProject_Click;
            // 
            // LoadProject
            // 
            LoadProject.BackColor = Color.FromArgb(159, 136, 166);
            LoadProject.FlatStyle = FlatStyle.Popup;
            LoadProject.Font = new Font("SimSun", 12F);
            LoadProject.Location = new Point(12, 214);
            LoadProject.Name = "LoadProject";
            LoadProject.Size = new Size(180, 24);
            LoadProject.TabIndex = 2;
            LoadProject.Text = "Load Project";
            LoadProject.UseVisualStyleBackColor = false;
            LoadProject.Click += LoadProject_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1280, 128);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Website
            // 
            Website.BackColor = Color.FromArgb(159, 136, 166);
            Website.FlatStyle = FlatStyle.Popup;
            Website.Font = new Font("SimSun", 12F);
            Website.Location = new Point(12, 244);
            Website.Name = "Website";
            Website.Size = new Size(180, 24);
            Website.TabIndex = 4;
            Website.Text = "Sinislosion.net";
            Website.UseVisualStyleBackColor = false;
            Website.Click += Website_Click;
            // 
            // ProjectNameInput
            // 
            ProjectNameInput.Font = new Font("SimSun", 12F);
            ProjectNameInput.Location = new Point(199, 182);
            ProjectNameInput.Name = "ProjectNameInput";
            ProjectNameInput.PlaceholderText = "Project Name";
            ProjectNameInput.Size = new Size(209, 26);
            ProjectNameInput.TabIndex = 5;
            // 
            // ConsoleButton
            // 
            ConsoleButton.BackColor = Color.FromArgb(159, 136, 166);
            ConsoleButton.FlatStyle = FlatStyle.Popup;
            ConsoleButton.Font = new Font("SimSun", 12F);
            ConsoleButton.Location = new Point(12, 274);
            ConsoleButton.Name = "ConsoleButton";
            ConsoleButton.Size = new Size(180, 24);
            ConsoleButton.TabIndex = 6;
            ConsoleButton.Text = "Check Path";
            ConsoleButton.UseVisualStyleBackColor = false;
            ConsoleButton.Click += ConsoleButton_Click;
            // 
            // ConsolePathInput
            // 
            ConsolePathInput.Font = new Font("SimSun", 12F);
            ConsolePathInput.Location = new Point(199, 272);
            ConsolePathInput.Name = "ConsolePathInput";
            ConsolePathInput.PlaceholderText = "Path to your MingW64 console";
            ConsolePathInput.Size = new Size(209, 26);
            ConsolePathInput.TabIndex = 7;
            ConsolePathInput.Text = "C:/msys64/mingw64.exe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 209, 255);
            ClientSize = new Size(1264, 681);
            Controls.Add(ConsolePathInput);
            Controls.Add(ConsoleButton);
            Controls.Add(ProjectNameInput);
            Controls.Add(Website);
            Controls.Add(LoadProject);
            Controls.Add(NewProject);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Raquet Studio";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button NewProject;
        private Button LoadProject;
        private PictureBox pictureBox2;
        private Button Website;
        private TextBox ProjectNameInput;
        private Button ConsoleButton;
        private TextBox ConsolePathInput;
    }
}
