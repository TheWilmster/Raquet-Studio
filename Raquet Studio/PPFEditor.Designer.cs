namespace Raquet_Studio
{
    partial class PPFEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPFEditor));
            pictureBox2 = new PictureBox();
            TilePreview = new PictureBox();
            FileName = new Label();
            TileSwitcher = new NumericUpDown();
            PreviewLabel = new Label();
            IndexLabel = new Label();
            TilePanel = new Panel();
            colorDialog1 = new ColorDialog();
            ColorTransparent = new PictureBox();
            ColorPal1 = new PictureBox();
            ColorPal2 = new PictureBox();
            ColorPal3 = new PictureBox();
            LabelTransparent = new Label();
            LabelPal1 = new Label();
            LabelPal2 = new Label();
            LabelPal3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TilePreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TileSwitcher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorTransparent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorPal1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorPal2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorPal3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(484, 64);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // TilePreview
            // 
            TilePreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TilePreview.BackColor = Color.LavenderBlush;
            TilePreview.BackgroundImageLayout = ImageLayout.Stretch;
            TilePreview.BorderStyle = BorderStyle.Fixed3D;
            TilePreview.Location = new Point(312, 86);
            TilePreview.Margin = new Padding(4, 2, 4, 2);
            TilePreview.Name = "TilePreview";
            TilePreview.Size = new Size(160, 160);
            TilePreview.TabIndex = 20;
            TilePreview.TabStop = false;
            // 
            // FileName
            // 
            FileName.AutoSize = true;
            FileName.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            FileName.Location = new Point(6, 70);
            FileName.Margin = new Padding(4, 0, 4, 0);
            FileName.Name = "FileName";
            FileName.Size = new Size(88, 16);
            FileName.TabIndex = 21;
            FileName.Text = "File Name";
            // 
            // TileSwitcher
            // 
            TileSwitcher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TileSwitcher.Location = new Point(268, 105);
            TileSwitcher.Margin = new Padding(4, 2, 4, 2);
            TileSwitcher.Name = "TileSwitcher";
            TileSwitcher.Size = new Size(43, 23);
            TileSwitcher.TabIndex = 22;
            TileSwitcher.ValueChanged += TileSwitcher_ValueChanged;
            // 
            // PreviewLabel
            // 
            PreviewLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PreviewLabel.AutoSize = true;
            PreviewLabel.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            PreviewLabel.Location = new Point(402, 68);
            PreviewLabel.Margin = new Padding(4, 0, 4, 0);
            PreviewLabel.Name = "PreviewLabel";
            PreviewLabel.Size = new Size(70, 16);
            PreviewLabel.TabIndex = 23;
            PreviewLabel.Text = "Preview";
            PreviewLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            IndexLabel.Location = new Point(268, 87);
            IndexLabel.Margin = new Padding(4, 0, 4, 0);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(43, 16);
            IndexLabel.TabIndex = 24;
            IndexLabel.Text = "Tile";
            IndexLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // TilePanel
            // 
            TilePanel.BackColor = Color.LavenderBlush;
            TilePanel.Dock = DockStyle.Bottom;
            TilePanel.Location = new Point(0, 249);
            TilePanel.Margin = new Padding(4, 2, 4, 2);
            TilePanel.Name = "TilePanel";
            TilePanel.Size = new Size(484, 32);
            TilePanel.TabIndex = 25;
            // 
            // ColorTransparent
            // 
            ColorTransparent.BackColor = Color.Black;
            ColorTransparent.BorderStyle = BorderStyle.Fixed3D;
            ColorTransparent.Location = new Point(6, 96);
            ColorTransparent.Name = "ColorTransparent";
            ColorTransparent.Size = new Size(32, 32);
            ColorTransparent.TabIndex = 26;
            ColorTransparent.TabStop = false;
            ColorTransparent.Click += ColorTransparent_Click;
            // 
            // ColorPal1
            // 
            ColorPal1.BackColor = Color.White;
            ColorPal1.BorderStyle = BorderStyle.Fixed3D;
            ColorPal1.Location = new Point(6, 134);
            ColorPal1.Name = "ColorPal1";
            ColorPal1.Size = new Size(32, 32);
            ColorPal1.TabIndex = 27;
            ColorPal1.TabStop = false;
            ColorPal1.Click += ColorPal1_Click;
            // 
            // ColorPal2
            // 
            ColorPal2.BackColor = Color.Gray;
            ColorPal2.BorderStyle = BorderStyle.Fixed3D;
            ColorPal2.Location = new Point(6, 172);
            ColorPal2.Name = "ColorPal2";
            ColorPal2.Size = new Size(32, 32);
            ColorPal2.TabIndex = 28;
            ColorPal2.TabStop = false;
            ColorPal2.Click += ColorPal2_Click;
            // 
            // ColorPal3
            // 
            ColorPal3.BackColor = Color.DarkGray;
            ColorPal3.BorderStyle = BorderStyle.Fixed3D;
            ColorPal3.Location = new Point(6, 210);
            ColorPal3.Name = "ColorPal3";
            ColorPal3.Size = new Size(32, 32);
            ColorPal3.TabIndex = 29;
            ColorPal3.TabStop = false;
            ColorPal3.Click += ColorPal3_Click;
            // 
            // LabelTransparent
            // 
            LabelTransparent.AutoSize = true;
            LabelTransparent.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LabelTransparent.Location = new Point(45, 112);
            LabelTransparent.Margin = new Padding(4, 0, 4, 0);
            LabelTransparent.Name = "LabelTransparent";
            LabelTransparent.Size = new Size(106, 16);
            LabelTransparent.TabIndex = 30;
            LabelTransparent.Text = "Transparent";
            // 
            // LabelPal1
            // 
            LabelPal1.AutoSize = true;
            LabelPal1.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LabelPal1.Location = new Point(45, 150);
            LabelPal1.Margin = new Padding(4, 0, 4, 0);
            LabelPal1.Name = "LabelPal1";
            LabelPal1.Size = new Size(70, 16);
            LabelPal1.TabIndex = 31;
            LabelPal1.Text = "Color 1";
            // 
            // LabelPal2
            // 
            LabelPal2.AutoSize = true;
            LabelPal2.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LabelPal2.Location = new Point(45, 188);
            LabelPal2.Margin = new Padding(4, 0, 4, 0);
            LabelPal2.Name = "LabelPal2";
            LabelPal2.Size = new Size(70, 16);
            LabelPal2.TabIndex = 32;
            LabelPal2.Text = "Color 2";
            // 
            // LabelPal3
            // 
            LabelPal3.AutoSize = true;
            LabelPal3.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LabelPal3.Location = new Point(45, 226);
            LabelPal3.Margin = new Padding(4, 0, 4, 0);
            LabelPal3.Name = "LabelPal3";
            LabelPal3.Size = new Size(70, 16);
            LabelPal3.TabIndex = 33;
            LabelPal3.Text = "Color 3";
            // 
            // PPFEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(484, 281);
            Controls.Add(LabelPal3);
            Controls.Add(LabelPal2);
            Controls.Add(LabelPal1);
            Controls.Add(LabelTransparent);
            Controls.Add(ColorPal3);
            Controls.Add(ColorPal2);
            Controls.Add(ColorPal1);
            Controls.Add(ColorTransparent);
            Controls.Add(TilePanel);
            Controls.Add(IndexLabel);
            Controls.Add(PreviewLabel);
            Controls.Add(TileSwitcher);
            Controls.Add(FileName);
            Controls.Add(TilePreview);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            Name = "PPFEditor";
            Text = "PPF Editor";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)TilePreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)TileSwitcher).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorTransparent).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorPal1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorPal2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorPal3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox TilePreview;
        private Label FileName;
        private NumericUpDown TileSwitcher;
        private Label PreviewLabel;
        private Label IndexLabel;
        private Panel TilePanel;
        private ColorDialog colorDialog1;
        private PictureBox ColorTransparent;
        private PictureBox ColorPal1;
        private PictureBox ColorPal2;
        private PictureBox ColorPal3;
        private Label LabelTransparent;
        private Label LabelPal1;
        private Label LabelPal2;
        private Label LabelPal3;
    }
}