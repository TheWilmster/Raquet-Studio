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
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("BigBlueTerm437 Nerd Font Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
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
            TextField.Location = new Point(12, 41);
            TextField.Name = "TextField";
            TextField.Size = new Size(776, 397);
            TextField.TabIndex = 1;
            TextField.Text = "";
            // 
            // SaveStatus
            // 
            SaveStatus.AutoSize = true;
            SaveStatus.Font = new Font("BigBlueTerm437 Nerd Font Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
            SaveStatus.ForeColor = SystemColors.ControlDark;
            SaveStatus.Location = new Point(93, 15);
            SaveStatus.Name = "SaveStatus";
            SaveStatus.Size = new Size(84, 16);
            SaveStatus.TabIndex = 2;
            SaveStatus.Text = "Unsaved";
            // 
            // FileName
            // 
            FileName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileName.AutoSize = true;
            FileName.Font = new Font("BigBlueTerm437 Nerd Font Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
            FileName.Location = new Point(682, 15);
            FileName.Name = "FileName";
            FileName.Size = new Size(106, 16);
            FileName.TabIndex = 3;
            FileName.Text = "File Name";
            FileName.TextAlign = ContentAlignment.TopRight;
            // 
            // ScriptEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FileName);
            Controls.Add(SaveStatus);
            Controls.Add(TextField);
            Controls.Add(SaveButton);
            Name = "ScriptEditor";
            Text = "Form2";
            Load += ScriptEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private RichTextBox TextField;
        private Label SaveStatus;
        private Label FileName;
    }
}