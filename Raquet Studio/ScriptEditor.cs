using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Raquet_Studio
{
    public partial class ScriptEditor : Form
    {
        public string scriptPath;
        public string scriptName;

        const int WM_VSCROLL = 0x115;
        const int WM_USER = 0x400;
        const int SB_VERT = 1;
        private const int EM_SETSCROLLPOS = WM_USER + 222;
        private const int EM_GETSCROLLPOS = WM_USER + 221;

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, ref Point lParam);

        public ScriptEditor(string name, string path)
        {
            InitializeComponent();
            scriptName = name;
            scriptPath = path;
        }

        private void ScriptEditor_Load(object sender, EventArgs e)
        {
            FileName.Text = scriptName;
            TextField.Text = File.ReadAllText(scriptPath);
            TextField.WordWrap = false;
            LineNumbering.WordWrap = false;
            int places = TextField.Lines.Length.ToString().Length;
            LineNumbering.Width = places * 12;
            SaveStatus.Text = "Unsaved";
            TextField.Location = new Point(LineNumbering.Location.X + LineNumbering.Width, TextField.Location.Y);
            TextField.Width = 776 - LineNumbering.Width;
            UpdateSyntaxHighlighting();
            RefreshLineNumbers();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(scriptPath, TextField.Text);
            SaveStatus.Text = "Saved";
        }

        private void TextField_TextChanged(object sender, EventArgs e)
        {
            RefreshLineNumbers();
            ScrollLineNumbering();
        }

        void RefreshLineNumbers()
        {
            TextField.Refresh();

            string lineString = String.Empty;
            for (var i = 1; i < (TextField.Lines.Length + 1); i++)
            {
                lineString += i.ToString();
                lineString += "\n";
            }
            LineNumbering.Font = TextField.Font;
            LineNumbering.Text = lineString;
            LineNumbering.Refresh();
        }

        private void TextField_VScroll(object sender, EventArgs e)
        {
            ScrollLineNumbering();
            LineNumbering.Refresh();
        }

        void ScrollLineNumbering()
        {
            Point scrollPoint = Point.Empty;
            SendMessage(TextField.Handle, EM_GETSCROLLPOS, 0, ref scrollPoint);
            scrollPoint.X = 0;

            SendMessage(LineNumbering.Handle, EM_SETSCROLLPOS, 0, ref scrollPoint);
        }

        void UpdateSyntaxHighlighting()
        {
            Point scrollPoint = Point.Empty;
            SendMessage(TextField.Handle, EM_GETSCROLLPOS, 0, ref scrollPoint);

            int prevSelStart = TextField.SelectionStart;

            string code = TextField.Text;

            for (int i = 0; i < code.Length; i++)
            {
                //TextField.SelectionColor = Color.White;

                string c = code[i].ToString();

                if (c == "/")
                {
                    int startPos = i;
                    i++;
                    c = code[i].ToString();
                    if (c == "/")
                    {
                        while (c != "\n" && (i + 1) < code.Length)
                        {
                            i++;
                            c = code[i].ToString();
                        }

                        TextField.SelectionStart = startPos;
                        TextField.SelectionLength = i - startPos;
                        TextField.SelectionColor = Color.Green;
                    }
                    else if (c == "*")
                    {
                        string prevc = String.Empty;
                        while (!(c == "/" && prevc == "*") && (i + 1) < code.Length)
                        {
                            prevc = c;
                            i++;
                            c = code[i].ToString();
                        }

                        TextField.SelectionStart = startPos;
                        TextField.SelectionLength = (i - startPos) + 1;
                        TextField.SelectionColor = Color.Green;
                    }
                }
            }

            TextField.SelectionLength = 0;
            TextField.SelectionStart = prevSelStart;
            TextField.SelectionColor = Color.White;

            SendMessage(TextField.Handle, EM_SETSCROLLPOS, 0, ref scrollPoint);
            ScrollLineNumbering();
        }

        private void UpdateHighlightingButton_Click(object sender, EventArgs e)
        {
            UpdateSyntaxHighlighting();
        }
    }
}
