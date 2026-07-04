using System.Diagnostics;
using System.IO.Compression;

namespace Raquet_Studio
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();

            if (instance == null)
            {
                instance = this;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SwitchToProjectForm()
        {
            ProjectForm NextForm = new ProjectForm();
            NextForm.Location = Location;
            NextForm.StartPosition = FormStartPosition.Manual;
            NextForm.FormClosing += delegate { Close(); };
            NextForm.Show();
            Hide();
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

        private void Website_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "https://sinislosion.net";
            psi.UseShellExecute = true;
            Process.Start(psi);
        }

        private void ConsoleButton_Click(object sender, EventArgs e)
        {
            string path = ConsolePathInput.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show(String.Concat("Failed to find executable ", path, ", did you input the path wrong?"));
            }
            ProjectUtil.mingw64Path = path;
        }
    }
}
