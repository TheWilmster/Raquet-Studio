namespace Raquet_Studio
{
    partial class ActorEditor
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
            PositionLabel = new Label();
            StartPosX = new NumericUpDown();
            StartPosXLabel = new Label();
            StartPosYLabel = new Label();
            StartPosY = new NumericUpDown();
            OriginYLabel = new Label();
            OriginY = new NumericUpDown();
            OriginXLabel = new Label();
            OriginX = new NumericUpDown();
            OriginLabel = new Label();
            FileName = new Label();
            SaveStatus = new Label();
            SaveButton = new Button();
            label1 = new Label();
            AngleInput = new NumericUpDown();
            AngleLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)StartPosX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartPosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OriginY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OriginX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AngleInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Font = new Font("SimSun", 12F, FontStyle.Underline);
            PositionLabel.Location = new Point(10, 41);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(143, 16);
            PositionLabel.TabIndex = 0;
            PositionLabel.Text = "Starting Position";
            // 
            // StartPosX
            // 
            StartPosX.Font = new Font("SimSun", 12F);
            StartPosX.Location = new Point(33, 60);
            StartPosX.Name = "StartPosX";
            StartPosX.Size = new Size(48, 26);
            StartPosX.TabIndex = 1;
            // 
            // StartPosXLabel
            // 
            StartPosXLabel.AutoSize = true;
            StartPosXLabel.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartPosXLabel.Location = new Point(10, 60);
            StartPosXLabel.Name = "StartPosXLabel";
            StartPosXLabel.Size = new Size(23, 16);
            StartPosXLabel.TabIndex = 3;
            StartPosXLabel.Text = "x:";
            // 
            // StartPosYLabel
            // 
            StartPosYLabel.AutoSize = true;
            StartPosYLabel.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartPosYLabel.Location = new Point(87, 60);
            StartPosYLabel.Name = "StartPosYLabel";
            StartPosYLabel.Size = new Size(23, 16);
            StartPosYLabel.TabIndex = 5;
            StartPosYLabel.Text = "y:";
            // 
            // StartPosY
            // 
            StartPosY.Font = new Font("SimSun", 12F);
            StartPosY.Location = new Point(108, 60);
            StartPosY.Name = "StartPosY";
            StartPosY.Size = new Size(48, 26);
            StartPosY.TabIndex = 4;
            // 
            // OriginYLabel
            // 
            OriginYLabel.AutoSize = true;
            OriginYLabel.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OriginYLabel.Location = new Point(87, 122);
            OriginYLabel.Name = "OriginYLabel";
            OriginYLabel.Size = new Size(23, 16);
            OriginYLabel.TabIndex = 10;
            OriginYLabel.Text = "y:";
            // 
            // OriginY
            // 
            OriginY.Font = new Font("SimSun", 12F);
            OriginY.Location = new Point(108, 122);
            OriginY.Name = "OriginY";
            OriginY.Size = new Size(48, 26);
            OriginY.TabIndex = 9;
            // 
            // OriginXLabel
            // 
            OriginXLabel.AutoSize = true;
            OriginXLabel.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OriginXLabel.Location = new Point(10, 122);
            OriginXLabel.Name = "OriginXLabel";
            OriginXLabel.Size = new Size(23, 16);
            OriginXLabel.TabIndex = 8;
            OriginXLabel.Text = "x:";
            // 
            // OriginX
            // 
            OriginX.Font = new Font("SimSun", 12F);
            OriginX.Location = new Point(33, 122);
            OriginX.Name = "OriginX";
            OriginX.Size = new Size(48, 26);
            OriginX.TabIndex = 7;
            // 
            // OriginLabel
            // 
            OriginLabel.AutoSize = true;
            OriginLabel.Font = new Font("SimSun", 12F, FontStyle.Underline);
            OriginLabel.Location = new Point(10, 103);
            OriginLabel.Name = "OriginLabel";
            OriginLabel.Size = new Size(55, 16);
            OriginLabel.TabIndex = 6;
            OriginLabel.Text = "Origin";
            // 
            // FileName
            // 
            FileName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileName.AutoSize = true;
            FileName.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileName.Location = new Point(266, 15);
            FileName.Name = "FileName";
            FileName.Size = new Size(79, 16);
            FileName.TabIndex = 13;
            FileName.Text = "File Name";
            FileName.TextAlign = ContentAlignment.TopRight;
            // 
            // SaveStatus
            // 
            SaveStatus.AutoSize = true;
            SaveStatus.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveStatus.ForeColor = Color.MediumOrchid;
            SaveStatus.Location = new Point(93, 15);
            SaveStatus.Name = "SaveStatus";
            SaveStatus.Size = new Size(63, 16);
            SaveStatus.TabIndex = 12;
            SaveStatus.Text = "Unsaved";
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(12, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 185);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 14;
            // 
            // AngleInput
            // 
            AngleInput.Font = new Font("SimSun", 12F);
            AngleInput.Location = new Point(71, 166);
            AngleInput.Name = "AngleInput";
            AngleInput.Size = new Size(48, 26);
            AngleInput.TabIndex = 16;
            // 
            // AngleLabel
            // 
            AngleLabel.AutoSize = true;
            AngleLabel.Font = new Font("SimSun", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            AngleLabel.Location = new Point(10, 166);
            AngleLabel.Name = "AngleLabel";
            AngleLabel.Size = new Size(55, 16);
            AngleLabel.TabIndex = 15;
            AngleLabel.Text = "Angle:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Location = new Point(244, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // ActorEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(384, 217);
            Controls.Add(pictureBox1);
            Controls.Add(AngleInput);
            Controls.Add(AngleLabel);
            Controls.Add(label1);
            Controls.Add(FileName);
            Controls.Add(SaveStatus);
            Controls.Add(SaveButton);
            Controls.Add(OriginYLabel);
            Controls.Add(OriginY);
            Controls.Add(OriginXLabel);
            Controls.Add(OriginX);
            Controls.Add(OriginLabel);
            Controls.Add(StartPosYLabel);
            Controls.Add(StartPosY);
            Controls.Add(StartPosXLabel);
            Controls.Add(StartPosX);
            Controls.Add(PositionLabel);
            Name = "ActorEditor";
            Text = "Actor Editor";
            ((System.ComponentModel.ISupportInitialize)StartPosX).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartPosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)OriginY).EndInit();
            ((System.ComponentModel.ISupportInitialize)OriginX).EndInit();
            ((System.ComponentModel.ISupportInitialize)AngleInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PositionLabel;
        private NumericUpDown StartPosX;
        private Label StartPosXLabel;
        private Label StartPosYLabel;
        private NumericUpDown StartPosY;
        private Label OriginYLabel;
        private NumericUpDown OriginY;
        private Label OriginXLabel;
        private NumericUpDown OriginX;
        private Label OriginLabel;
        private Label FileName;
        private Label SaveStatus;
        private Button SaveButton;
        private Label label1;
        private NumericUpDown AngleInput;
        private Label AngleLabel;
        private PictureBox pictureBox1;
    }
}