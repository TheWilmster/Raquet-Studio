namespace Raquet_Studio
{
    partial class EventSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventSelector));
            EventList = new ListBox();
            CancelButton = new Button();
            AddButton = new Button();
            EventsLabel = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // EventList
            // 
            EventList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EventList.FormattingEnabled = true;
            EventList.Location = new Point(14, 30);
            EventList.Margin = new Padding(5, 2, 5, 2);
            EventList.Name = "EventList";
            EventList.Size = new Size(276, 196);
            EventList.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.BackColor = Color.Purple;
            CancelButton.Font = new Font("SimSun", 12F);
            CancelButton.ForeColor = Color.LemonChiffon;
            CancelButton.Location = new Point(205, 242);
            CancelButton.Margin = new Padding(5, 2, 5, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(86, 30);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddButton.BackColor = Color.LemonChiffon;
            AddButton.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.Purple;
            AddButton.Location = new Point(112, 242);
            AddButton.Margin = new Padding(5, 2, 5, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(86, 30);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // EventsLabel
            // 
            EventsLabel.AutoSize = true;
            EventsLabel.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            EventsLabel.Location = new Point(14, 9);
            EventsLabel.Margin = new Padding(5, 0, 5, 0);
            EventsLabel.Name = "EventsLabel";
            EventsLabel.Size = new Size(61, 16);
            EventsLabel.TabIndex = 3;
            EventsLabel.Text = "Events";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(304, 64);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // EventSelector
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(304, 281);
            Controls.Add(EventsLabel);
            Controls.Add(AddButton);
            Controls.Add(CancelButton);
            Controls.Add(EventList);
            Controls.Add(pictureBox2);
            Font = new Font("SimSun", 12F);
            Margin = new Padding(5, 2, 5, 2);
            Name = "EventSelector";
            Text = "Choose Event";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox EventList;
        private Button CancelButton;
        private Button AddButton;
        private Label EventsLabel;
        private PictureBox pictureBox2;
    }
}