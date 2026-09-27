using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Raquet_Studio
{
    public partial class PPFEditor : Form
    {
        List<byte[]> ppfData;

        public PPFEditor(List<byte[]> ppfData)
        {
            InitializeComponent();
            this.ppfData = ppfData;
            UpdatePreview();
            UpdateTileList();
            colorDialog1.AllowFullOpen = true;
        }
        private void UpdatePreview()
        {
            TilePreview.BackgroundImage = ProjectUtil.RenderCHR(ppfData[(int)TileSwitcher.Value], TilePreview.Width, TilePreview.Height, [ColorTransparent.BackColor, ColorPal1.BackColor, ColorPal2.BackColor, ColorPal3.BackColor]);
        }
        private async void UpdateTileList()
        {
            int i = 0;
            TilePanel.Controls.Clear();
            foreach (byte[] tileData in ppfData)
            {
                if (tileData.Length < 16)
                {
                    continue;
                }

                PictureBox tile = new PictureBox()
                {
                    Width = TilePanel.Height,
                    Height = TilePanel.Height,
                    Location = new Point((++i) * TilePanel.Height, 0),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = ProjectUtil.RenderCHR(ppfData[i], TilePanel.Width, TilePanel.Height, [ColorTransparent.BackColor, ColorPal1.BackColor, ColorPal2.BackColor, ColorPal3.BackColor])
                };
                TilePanel.Controls.Add(tile);
                Invalidate();
            }
        }

        private void TileSwitcher_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void ColorTransparent_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorTransparent.BackColor = colorDialog1.Color;
                UpdateTileList();
                UpdatePreview();
            }
        }

        private void ColorPal1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorPal1.BackColor = colorDialog1.Color;
                UpdateTileList();
                UpdatePreview();
            }
        }

        private void ColorPal2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorPal2.BackColor = colorDialog1.Color;
                UpdateTileList();
                UpdatePreview();
            }
        }

        private void ColorPal3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorPal3.BackColor = colorDialog1.Color;
                UpdateTileList();
                UpdatePreview();
            }
        }
    }
}
