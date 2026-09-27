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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorEditor));
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
            pictureBox2 = new PictureBox();
            EventList = new ListBox();
            AddEvent = new Button();
            EventsLabel = new Label();
            DeleteEvent = new Button();
            EditEvent = new Button();
            ((System.ComponentModel.ISupportInitialize)OriginY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OriginX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AngleInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // OriginYLabel
            // 
            OriginYLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OriginYLabel.AutoSize = true;
            OriginYLabel.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OriginYLabel.Location = new Point(102, 137);
            OriginYLabel.Name = "OriginYLabel";
            OriginYLabel.Size = new Size(23, 16);
            OriginYLabel.TabIndex = 10;
            OriginYLabel.Text = "y:";
            // 
            // OriginY
            // 
            OriginY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OriginY.Font = new Font("SimSun", 12F);
            OriginY.Location = new Point(131, 137);
            OriginY.Name = "OriginY";
            OriginY.Size = new Size(48, 26);
            OriginY.TabIndex = 9;
            OriginY.ValueChanged += OriginY_ValueChanged;
            // 
            // OriginXLabel
            // 
            OriginXLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OriginXLabel.AutoSize = true;
            OriginXLabel.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OriginXLabel.Location = new Point(14, 137);
            OriginXLabel.Name = "OriginXLabel";
            OriginXLabel.Size = new Size(23, 16);
            OriginXLabel.TabIndex = 8;
            OriginXLabel.Text = "x:";
            // 
            // OriginX
            // 
            OriginX.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OriginX.Font = new Font("SimSun", 12F);
            OriginX.Location = new Point(43, 137);
            OriginX.Name = "OriginX";
            OriginX.Size = new Size(48, 26);
            OriginX.TabIndex = 7;
            OriginX.ValueChanged += OriginX_ValueChanged;
            // 
            // OriginLabel
            // 
            OriginLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OriginLabel.AutoSize = true;
            OriginLabel.Font = new Font("SimSun", 12F, FontStyle.Underline);
            OriginLabel.Location = new Point(14, 112);
            OriginLabel.Name = "OriginLabel";
            OriginLabel.Size = new Size(55, 16);
            OriginLabel.TabIndex = 6;
            OriginLabel.Text = "Origin";
            // 
            // FileName
            // 
            FileName.AutoSize = true;
            FileName.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            FileName.Location = new Point(15, 71);
            FileName.Name = "FileName";
            FileName.Size = new Size(88, 16);
            FileName.TabIndex = 13;
            FileName.Text = "File Name";
            FileName.TextAlign = ContentAlignment.TopRight;
            // 
            // SaveStatus
            // 
            SaveStatus.AutoSize = true;
            SaveStatus.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveStatus.ForeColor = Color.MediumOrchid;
            SaveStatus.Location = new Point(106, 16);
            SaveStatus.Name = "SaveStatus";
            SaveStatus.Size = new Size(63, 16);
            SaveStatus.TabIndex = 12;
            SaveStatus.Text = "Unsaved";
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(14, 13);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(86, 25);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 197);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 14;
            // 
            // AngleInput
            // 
            AngleInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AngleInput.Font = new Font("SimSun", 12F);
            AngleInput.Location = new Point(75, 177);
            AngleInput.Name = "AngleInput";
            AngleInput.Size = new Size(48, 26);
            AngleInput.TabIndex = 16;
            AngleInput.ValueChanged += AngleInput_ValueChanged;
            // 
            // AngleLabel
            // 
            AngleLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AngleLabel.AutoSize = true;
            AngleLabel.Font = new Font("SimSun", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            AngleLabel.Location = new Point(14, 179);
            AngleLabel.Name = "AngleLabel";
            AngleLabel.Size = new Size(55, 16);
            AngleLabel.TabIndex = 15;
            AngleLabel.Text = "Angle:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(439, 64);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // EventList
            // 
            EventList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            EventList.FormattingEnabled = true;
            EventList.Location = new Point(187, 91);
            EventList.Name = "EventList";
            EventList.Size = new Size(237, 100);
            EventList.TabIndex = 19;
            EventList.SelectedIndexChanged += EventList_SelectedIndexChanged;
            // 
            // AddEvent
            // 
            AddEvent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddEvent.BackColor = Color.LemonChiffon;
            AddEvent.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddEvent.ForeColor = Color.Purple;
            AddEvent.Location = new Point(187, 192);
            AddEvent.Name = "AddEvent";
            AddEvent.Size = new Size(79, 29);
            AddEvent.TabIndex = 20;
            AddEvent.Text = "Add";
            AddEvent.UseVisualStyleBackColor = false;
            AddEvent.Click += AddEvent_Click;
            // 
            // EventsLabel
            // 
            EventsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            EventsLabel.AutoSize = true;
            EventsLabel.Font = new Font("SimSun", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            EventsLabel.Location = new Point(187, 71);
            EventsLabel.Name = "EventsLabel";
            EventsLabel.Size = new Size(55, 16);
            EventsLabel.TabIndex = 21;
            EventsLabel.Text = "Events";
            EventsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DeleteEvent
            // 
            DeleteEvent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteEvent.BackColor = Color.Purple;
            DeleteEvent.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteEvent.ForeColor = Color.LemonChiffon;
            DeleteEvent.Location = new Point(346, 192);
            DeleteEvent.Name = "DeleteEvent";
            DeleteEvent.Size = new Size(79, 29);
            DeleteEvent.TabIndex = 22;
            DeleteEvent.Text = "Delete";
            DeleteEvent.UseVisualStyleBackColor = false;
            // 
            // EditEvent
            // 
            EditEvent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditEvent.BackColor = Color.White;
            EditEvent.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditEvent.ForeColor = SystemColors.MenuText;
            EditEvent.Location = new Point(266, 192);
            EditEvent.Name = "EditEvent";
            EditEvent.Size = new Size(80, 29);
            EditEvent.TabIndex = 23;
            EditEvent.Text = "Edit";
            EditEvent.UseVisualStyleBackColor = false;
            EditEvent.Click += EditEvent_Click;
            // 
            // ActorEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(439, 231);
            Controls.Add(EditEvent);
            Controls.Add(DeleteEvent);
            Controls.Add(EventsLabel);
            Controls.Add(AddEvent);
            Controls.Add(EventList);
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
            Controls.Add(pictureBox2);
            Font = new Font("SimSun", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ActorEditor";
            Text = "Actor Editor";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)OriginY).EndInit();
            ((System.ComponentModel.ISupportInitialize)OriginX).EndInit();
            ((System.ComponentModel.ISupportInitialize)AngleInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private PictureBox pictureBox2;
        private ListBox EventList;
        private Button AddEvent;
        private Label EventsLabel;
        private Button DeleteEvent;
        private Button EditEvent;
    }
}