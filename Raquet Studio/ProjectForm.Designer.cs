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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            ScriptList.Font = new Font("BigBlueTerm437 Nerd Font Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
            ScriptList.ForeColor = Color.Purple;
            ScriptList.Location = new Point(0, 134);
            ScriptList.Name = "ScriptList";
            ScriptList.Size = new Size(128, 546);
            ScriptList.TabIndex = 6;
            // 
            // RunButton
            // 
            RunButton.Font = new Font("BigBlueTerm437 Nerd Font Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
            RunButton.Location = new Point(12, 12);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(58, 23);
            RunButton.TabIndex = 7;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // CleanRunButton
            // 
            CleanRunButton.Font = new Font("BigBlueTerm437 Nerd Font Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
            CleanRunButton.Location = new Point(76, 12);
            CleanRunButton.Name = "CleanRunButton";
            CleanRunButton.Size = new Size(123, 23);
            CleanRunButton.TabIndex = 8;
            CleanRunButton.Text = "Clean Run";
            CleanRunButton.UseVisualStyleBackColor = true;
            CleanRunButton.Click += CleanRunButton_Click;
            // 
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 209, 255);
            ClientSize = new Size(1264, 681);
            Controls.Add(CleanRunButton);
            Controls.Add(RunButton);
            Controls.Add(ScriptList);
            Controls.Add(pictureBox2);
            Name = "ProjectForm";
            Text = "ProjectForm";
            Load += ProjectForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private FlowLayoutPanel ScriptList;
        private Button RunButton;
        private Button CleanRunButton;
    }
}