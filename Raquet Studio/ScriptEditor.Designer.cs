namespace Raquet_Studio
{
    partial class ScriptEditor
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
            SaveButton = new Button();
            TextField = new RichTextBox();
            SaveStatus = new Label();
            FileName = new Label();
            LineNumbering = new RichTextBox();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(12, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // TextField
            // 
            TextField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextField.BackColor = Color.FromArgb(37, 0, 49);
            TextField.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextField.ForeColor = Color.LavenderBlush;
            TextField.Location = new Point(36, 41);
            TextField.Margin = new Padding(0, 3, 3, 3);
            TextField.Name = "TextField";
            TextField.Size = new Size(752, 397);
            TextField.TabIndex = 1;
            TextField.Text = "";
            TextField.VScroll += TextField_VScroll;
            TextField.TextChanged += TextField_TextChanged;
            // 
            // SaveStatus
            // 
            SaveStatus.AutoSize = true;
            SaveStatus.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveStatus.ForeColor = Color.MediumOrchid;
            SaveStatus.Location = new Point(93, 15);
            SaveStatus.Name = "SaveStatus";
            SaveStatus.Size = new Size(63, 16);
            SaveStatus.TabIndex = 2;
            SaveStatus.Text = "Unsaved";
            // 
            // FileName
            // 
            FileName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileName.AutoSize = true;
            FileName.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileName.Location = new Point(682, 15);
            FileName.Name = "FileName";
            FileName.Size = new Size(79, 16);
            FileName.TabIndex = 3;
            FileName.Text = "File Name";
            FileName.TextAlign = ContentAlignment.TopRight;
            // 
            // LineNumbering
            // 
            LineNumbering.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LineNumbering.BackColor = Color.Plum;
            LineNumbering.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LineNumbering.Location = new Point(12, 41);
            LineNumbering.Margin = new Padding(3, 3, 0, 3);
            LineNumbering.Name = "LineNumbering";
            LineNumbering.ReadOnly = true;
            LineNumbering.ScrollBars = RichTextBoxScrollBars.None;
            LineNumbering.Size = new Size(24, 397);
            LineNumbering.TabIndex = 4;
            LineNumbering.Text = "";
            // 
            // ScriptEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(LineNumbering);
            Controls.Add(FileName);
            Controls.Add(SaveStatus);
            Controls.Add(TextField);
            Controls.Add(SaveButton);
            Name = "ScriptEditor";
            Text = "Script Editor";
            Load += ScriptEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private RichTextBox TextField;
        private Label SaveStatus;
        private Label FileName;
        private RichTextBox LineNumbering;
    }
}