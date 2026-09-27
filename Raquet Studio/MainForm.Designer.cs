namespace Raquet_Studio
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            NewProject = new Button();
            LoadProject = new Button();
            pictureBox2 = new PictureBox();
            Website = new Button();
            ProjectNameInput = new TextBox();
            ConsoleButton = new Button();
            ConsolePathInput = new TextBox();
            Rainbit = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            FooterBG = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rainbit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FooterBG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // Rainbit
            // 
            Rainbit.BackgroundImage = (Image)resources.GetObject("Rainbit.BackgroundImage");
            Rainbit.Location = new Point(0, 589);
            Rainbit.Name = "Rainbit";
            Rainbit.Size = new Size(1648, 8);
            Rainbit.TabIndex = 8;
            Rainbit.TabStop = false;
            Rainbit.LoadCompleted += Rainbit_LoadCompleted;
            Rainbit.Paint += Rainbit_Paint;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FooterBG
            // 
            FooterBG.BackColor = Color.Black;
            FooterBG.Dock = DockStyle.Bottom;
            FooterBG.Location = new Point(0, 589);
            FooterBG.Name = "FooterBG";
            FooterBG.Size = new Size(1264, 92);
            FooterBG.TabIndex = 9;
            FooterBG.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 603);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(530, 66);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox3);
            Controls.Add(Rainbit);
            Controls.Add(FooterBG);
            Controls.Add(ConsolePathInput);
            Controls.Add(ConsoleButton);
            Controls.Add(ProjectNameInput);
            Controls.Add(Website);
            Controls.Add(LoadProject);
            Controls.Add(NewProject);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raquet Studio";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rainbit).EndInit();
            ((System.ComponentModel.ISupportInitialize)FooterBG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox Rainbit;
        private System.Windows.Forms.Timer timer1;
        private PictureBox FooterBG;
        private PictureBox pictureBox3;
    }
}
