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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
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
            TextField.Location = new Point(36, 41);
            TextField.Name = "TextField";
            TextField.Size = new Size(752, 397);
            TextField.TabIndex = 1;
            TextField.Text = "";
            TextField.TextChanged += TextField_TextChanged;
            // 
            // SaveStatus
            // 
            SaveStatus.AutoSize = true;
            SaveStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
            SaveStatus.ForeColor = SystemColors.ControlDark;
            SaveStatus.Location = new Point(93, 15);
            SaveStatus.Name = "SaveStatus";
            SaveStatus.Size = new Size(72, 20);
            SaveStatus.TabIndex = 2;
            SaveStatus.Text = "Unsaved";
            // 
            // FileName
            // 
            FileName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileName.AutoSize = true;
            FileName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 255);
            FileName.Location = new Point(682, 15);
            FileName.Name = "FileName";
            FileName.Size = new Size(80, 20);
            FileName.TabIndex = 3;
            FileName.Text = "File Name";
            FileName.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(24, 29);
            textBox1.TabIndex = 4;
            // 
            // ScriptEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
    }
}