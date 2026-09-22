using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

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

        const string alphabet = "_ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        const string digits = "1234567890";
        string[] keywords = [
            "auto",
            "break",
            "case",
            "char",
            "const",
            "continue",
            "default",
            "do",
            "double",
            "else",
            "enum",
            "extern",
            "float",
            "for",
            "goto",
            "if",
            "inline",
            "int",
            "long",
            "register",
            "restrict",
            "return",
            "short",
            "signed",
            "sizeof",
            "static",
            "struct",
            "switch",
            "typedef",
            "union",
            "unsigned",
            "void",
            "volatile",
            "while",
            "_Bool",
            "_Complex",
            "_Imaginary",
            "__asm__",
            "__asm",
            "asm"
        ];
        string[] preprocKeywords = [
            "if",
            "elif",
            "else",
            "endif",
            "ifdef",
            "ifndef",
            "define",
            "undef",
            "include",
            "line",
            "error",
            "pragma",
            "defined"
        ];

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
            LineNumbering.Width = (places * 11) + 4;
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

            Color c_number = Color.FromArgb(236, 138, 131);
            Color c_keyword = Color.FromArgb(169, 131, 216);
            Color c_usertype = Color.FromArgb(106, 180, 241);
            Color c_preprockey = Color.FromArgb(255, 173, 133);
            Color c_comment = Color.FromArgb(139, 229, 157);
            Color c_string = Color.FromArgb(249, 241, 118);

            //string storedKey = string.Empty;

            for (int i = 0; i < code.Length; i++)
            {
                //TextField.SelectionColor = Color.White;

                string? c = code[i].ToString();

                if (c == "/")
                {
                    int startPos = i;
                    i++;
                    c = code[i].ToString();
                    if (c == "/")
                    {
                        while (c != "\n" && (i + 1) < code.Length)
                        {
                            c = code[++i].ToString();
                        }

                        TextField.SelectionStart = startPos;
                        TextField.SelectionLength = i - startPos;
                        TextField.SelectionColor = c_comment;
                    }
                    else if (c == "*")
                    {
                        string prevc = string.Empty;
                        while (!(c == "/" && prevc == "*") && (i + 1) < code.Length)
                        {
                            prevc = c;
                            c = code[++i].ToString();
                        }

                        TextField.SelectionStart = startPos;
                        TextField.SelectionLength = (i - startPos) + 1;
                        TextField.SelectionColor = c_comment;
                    }
                }
                if (alphabet.Contains(c) || c == "#")
                {
                    Color col = c_keyword;
                    int startPos = i;
                    if (c == "#")
                    {
                        col = c_preprockey;
                        c = code[++i].ToString();
                    }
                    string key = string.Empty;
                    while (alphabet.Contains(c) || digits.Contains(c))
                    {
                        key += c;
                        c = code[++i].ToString();
                    }
                    if ((keywords.Contains(key) && col == c_keyword) || (preprocKeywords.Contains(key) && col == c_preprockey))
                    {
                        TextField.SelectionStart = startPos;
                        TextField.SelectionLength = i - startPos;
                        TextField.SelectionColor = col;
                    }
                }
                if (c == "\"" || c == "\'")
                {
                    string startChar = c;
                    int startPos = i;
                    c = code[++i].ToString();
                    string str = string.Empty;
                    while (c != startChar)
                    {
                        str += c;
                        c = code[++i].ToString();
                    }
                    ++i;
                    TextField.SelectionStart = startPos;
                    TextField.SelectionLength = i - startPos;
                    TextField.SelectionColor = c_string;
                }
                if (digits.Contains(c))
                {
                    int startPos = i;
                    string key = string.Empty;
                    while (digits.Contains(c))
                    {
                        key += c;
                        i++;
                        c = code[i].ToString();
                    }
                    TextField.SelectionStart = startPos;
                    TextField.SelectionLength = i - startPos;
                    TextField.SelectionColor = c_number;
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
