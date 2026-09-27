using System.Diagnostics;
using System.IO.Compression;
//using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace Raquet_Studio
{
    public partial class MainForm : Form
    {
        public static MainForm? instance = null;

        public float scrollInterval = 1f;
        public float scroll = 0f;

        public MainForm()
        {
            InitializeComponent();

            if (instance == null)
            {
                instance = this;
            }
            instance.Text = "Raquet Studio";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            timer1.Interval = 16;
            timer1.Start();
        }

        private void SwitchToProjectForm()
        {
            ProjectForm NextForm = new ProjectForm()
            {
                StartPosition = FormStartPosition.Manual,
                Location = Location,
                Size = Size,
            };

            Border98 border = Border98.borders[this];
            border.SwitchForm(NextForm);
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProjectNameInput.Text) || string.IsNullOrEmpty(ProjectNameInput.Text))
            {
                MessageBox.Show("Please input a valid project name.", "Raquet Studio");
                return;
            }

            ProjectUtil.currentProjectPath = Path.Combine(ProjectUtil.projectsPath, ProjectNameInput.Text);
            if (!Directory.Exists(ProjectUtil.currentProjectPath))
                Directory.CreateDirectory(ProjectUtil.currentProjectPath);
            else
            {
                string text = "This project directory already exists, would you like to overwrite it ? (This will delete all files and folders within the project directory.)";
                DialogResult result = MessageBox.Show(text, "Raquet Studio", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                    return;

                Directory.Delete(ProjectUtil.currentProjectPath, true);
                Directory.CreateDirectory(ProjectUtil.currentProjectPath);
            }

            ZipFile.ExtractToDirectory(ProjectUtil.templatePath, ProjectUtil.currentProjectPath);

            SwitchToProjectForm();
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {

        }

        private async void Website_Click(object sender, EventArgs e)
        {
            /*ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "https://sinislosion.net";
            psi.UseShellExecute = true;
            Process.Start(psi);*/

            WebViewForm form = new("https://sinislosion.net");
            Border98 border = new(form);
        }

        private void Rainbit_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            scroll -= scrollInterval;
            if (scroll <= -1151)
            {
                scroll = 0;
            }
            Rainbit.Location = new Point((int)scroll, FooterBG.Location.Y);
            Invalidate();
        }

        private void Rainbit_Paint(object sender, PaintEventArgs e)
        {
            Rainbit.Width = Width * 2;
        }
    }
}
