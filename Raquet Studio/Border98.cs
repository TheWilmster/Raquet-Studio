using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Numerics;
using Microsoft.Web.WebView2.WinForms;

namespace Raquet_Studio
{
    public partial class Border98 : Form
    {
        Form form;
        PictureBox? draggingBorder;
        Point initialLocation;
        Point initialSize;
        Point relativeMousePosition;
        Dictionary<string, Image> buttonImages = [];
        Dictionary<string, Image> buttonPressedImages = [];
        bool fullscreen = false;
        Rectangle windowedRect = new();
        public static Dictionary<Form, Border98> borders = [];

        public Border98(Form form)
        {
            InitializeComponent();
            SwitchForm(form);

            InitBorder();
        }

        public Border98(WebView2 form)
        {
            InitializeComponent();
            //SwitchForm(form);

            InitBorder();
        }

        public void InitBorder()
        {
            buttonImages.Add(CloseButton.Name, imageList1.Images[0]);
            buttonPressedImages.Add(CloseButton.Name, imageList1.Images[1]);
            buttonImages.Add(FullscreenButton.Name, imageList1.Images[2]);
            buttonPressedImages.Add(FullscreenButton.Name, imageList1.Images[3]);
            buttonImages.Add(MinimizeButton.Name, imageList1.Images[4]);
            buttonPressedImages.Add(MinimizeButton.Name, imageList1.Images[5]);

            BorderRight.MouseDown += Border_MouseDown;
            BorderRight.MouseUp += Border_MouseUp;
            BorderLeft.MouseDown += Border_MouseDown;
            BorderLeft.MouseUp += Border_MouseUp;
            BorderBottom.MouseDown += Border_MouseDown;
            BorderBottom.MouseUp += Border_MouseUp;
            BorderTop.MouseDown += Border_MouseDown;
            BorderTop.MouseUp += Border_MouseUp;
            CornerBottomRight.MouseDown += Border_MouseDown;
            CornerBottomRight.MouseUp += Border_MouseUp;
            CornerBottomLeft.MouseDown += Border_MouseDown;
            CornerBottomLeft.MouseUp += Border_MouseUp;
            CornerTopRight.MouseDown += Border_MouseDown;
            CornerTopRight.MouseUp += Border_MouseUp;
            CornerTopLeft.MouseDown += Border_MouseDown;
            CornerTopLeft.MouseUp += Border_MouseUp;
            Gradient.MouseDown += Border_MouseDown;
            Gradient.MouseUp += Border_MouseUp;

            CloseButton.MouseDown += Button_MouseDown;
            CloseButton.MouseUp += Button_MouseUp;
            CloseButton.Click += delegate { Close(); form.Close(); };

            FullscreenButton.MouseDown += Button_MouseDown;
            FullscreenButton.MouseUp += Button_MouseUp;
            FullscreenButton.Click += ToggleFullscreen;

            MinimizeButton.MouseDown += Button_MouseDown;
            MinimizeButton.MouseUp += Button_MouseUp;
            MinimizeButton.Click += delegate { WindowState = FormWindowState.Minimized; };
        }

        public void SwitchForm(Form form)
        {
            if (this.form != null)
            {
                borders.Remove(this.form);
                WindowPanel.Controls.Clear();
                this.form.Dispose();
            }
            this.form = form;
            this.form.TopLevel = false;
            this.form.FormBorderStyle = FormBorderStyle.None;
            Width = this.form.Width + 12;
            Height = this.form.Height + 31;
            switch (this.form.StartPosition)
            {
                case FormStartPosition.CenterScreen:
                case FormStartPosition.CenterParent:
                    DesktopLocation = new Point((DisplayRectangle.Width / 2) - (Width / 2), (DisplayRectangle.Height / 2) - (Height / 2));
                    break;
                case FormStartPosition.WindowsDefaultLocation:
                case FormStartPosition.WindowsDefaultBounds:
                    DesktopLocation = this.form.DesktopLocation;
                    break;
            }
            this.form.Dock = DockStyle.Fill;
            WindowPanel.Controls.Add(this.form);
            this.form.Show();
            this.form.FormClosed += delegate { Close(); };
            borders[this.form] = this;
            Text = this.form.Text;
            Show();
            Invalidate();
        }

        private void Gradient_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            Point iconPos = new(1, 0);
            using (Bitmap bmp = form.Icon.ToBitmap())
                e.Graphics.DrawImage(bmp, iconPos.X, iconPos.Y, 16, 16);

            Font fnt = FontUtil.fonts["Microsoft Sans Serif"];
            Brush brush = new SolidBrush(Color.White);
            Point textPos = new(iconPos.X + 17, iconPos.Y + 2);
            e.Graphics.DrawString(form.Text, fnt, brush, textPos);
        }

        void ToggleFullscreen(object sender, EventArgs e)
        {
            fullscreen = !fullscreen;

            if (fullscreen)
            {
                windowedRect = new(DesktopLocation.X, DesktopLocation.Y, Width, Height);
                DesktopLocation = new(0, 0);
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;

                CornerBottomLeft.Cursor = Cursors.Default;
                CornerBottomRight.Cursor = Cursors.Default;
                CornerTopLeft.Cursor = Cursors.Default;
                CornerTopRight.Cursor = Cursors.Default;
                BorderTop.Cursor = Cursors.Default;
                BorderBottom.Cursor = Cursors.Default;
                BorderLeft.Cursor = Cursors.Default;
                BorderRight.Cursor = Cursors.Default;
            }
            else
            {
                if (draggingBorder == null || draggingBorder.Name != "Gradient") DesktopLocation = new(windowedRect.X, windowedRect.Y);
                Width = windowedRect.Width;
                Height = windowedRect.Height;

                CornerBottomLeft.Cursor = Cursors.SizeNESW;
                CornerBottomRight.Cursor = Cursors.SizeNWSE;
                CornerTopLeft.Cursor = Cursors.SizeNESW;
                CornerTopRight.Cursor = Cursors.SizeNWSE;
                BorderTop.Cursor = Cursors.SizeNS;
                BorderBottom.Cursor = Cursors.SizeNS;
                BorderLeft.Cursor = Cursors.SizeWE;
                BorderRight.Cursor = Cursors.SizeWE;
            }
        }

        void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            PictureBox? pictureBox = sender as PictureBox;
            pictureBox.Image = buttonPressedImages[pictureBox.Name];
        }
        void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            PictureBox? pictureBox = sender as PictureBox;
            pictureBox.Image = buttonImages[pictureBox.Name];
        }
        void Border_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox? border = sender as PictureBox;
            if (e.Button != MouseButtons.Left || (fullscreen && border.Name != "Gradient"))
                return;

            initialLocation = new(Location.X, Location.Y);
            initialSize = new(Width, Height);
            relativeMousePosition = new(MousePosition.X - DesktopLocation.X, MousePosition.Y - DesktopLocation.Y);

            draggingBorder = border;

            if (border.Name == "Gradient" && fullscreen)
            {
                int oldWidth = Width;
                ToggleFullscreen(sender, e);
                float perc = (float)Width / oldWidth;
                relativeMousePosition = new((int)(relativeMousePosition.X * perc), relativeMousePosition.Y);
            }

            timer1.Start();
        }
        void Border_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || (fullscreen && (draggingBorder == null || draggingBorder.Name != "Gradient")))
                return;

            if (draggingBorder.Name == "Gradient" && MousePosition.Y <= 2 && !fullscreen)
            {
                ToggleFullscreen(sender, e);
            }

            draggingBorder = null;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string name = draggingBorder.Name;

            int width = initialSize.X;
            switch (name)
            {
                case "BorderRight":
                    Width = Math.Max(MousePosition.X - DesktopLocation.X, 64);
                    break;
                case "BorderLeft":
                    DesktopLocation = new(MousePosition.X, DesktopLocation.Y);
                    Width = Math.Max((initialLocation.X + initialSize.X) - MousePosition.X, 64);
                    break;
                case "BorderBottom":
                    Height = Math.Max(MousePosition.Y - DesktopLocation.Y, 64);
                    break;
                case "BorderTop":
                    DesktopLocation = new(DesktopLocation.X, MousePosition.Y);
                    Height = Math.Max((initialLocation.Y + initialSize.Y) - MousePosition.Y, 64);
                    break;
                case "CornerBottomRight":
                    Width = Math.Max(MousePosition.X - DesktopLocation.X, 64);
                    Height = Math.Max(MousePosition.Y - DesktopLocation.Y, 64);
                    break;
                case "CornerBottomLeft":
                    DesktopLocation = new(MousePosition.X, DesktopLocation.Y);
                    Width = Math.Max((initialLocation.X + initialSize.X) - MousePosition.X, 64);
                    Height = Math.Max(MousePosition.Y - DesktopLocation.Y, 64);
                    break;
                case "CornerTopRight":
                    Width = Math.Max(MousePosition.X - DesktopLocation.X, 64);
                    DesktopLocation = new(DesktopLocation.X, MousePosition.Y);
                    Height = Math.Max((initialLocation.Y + initialSize.Y) - MousePosition.Y, 64);
                    break;
                case "CornerTopLeft":
                    DesktopLocation = new(MousePosition.X, MousePosition.Y);
                    Width = Math.Max((initialLocation.X + initialSize.X) - MousePosition.X, 64);
                    Height = Math.Max((initialLocation.Y + initialSize.Y) - MousePosition.Y, 64);
                    break;
                case "Gradient":
                    DesktopLocation = new(MousePosition.X - relativeMousePosition.X, MousePosition.Y - relativeMousePosition.Y);
                    break;
            }
        }
    }
}
