using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Raquet_Studio
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            bool fontCreated = FontUtil.LoadFont(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Fonts", "micross.ttf"), 8, FontStyle.Bold);
            if (!fontCreated) Debug.WriteLine("fack you");
        }

        private void SwitchToMainForm()
        {
            Border98 NextForm = new Border98(new MainForm());

            NextForm.FormClosing += delegate { Close(); };
            NextForm.Show();
            Hide();
        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            await Task.Delay(4000);
            SwitchToMainForm();
        }
    }
}
