using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;

namespace Raquet_Studio
{
    internal static class ProjectUtil
    {
        public static string resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
        public static string projectsPath = Path.Combine("C:/Users/", Environment.UserName, "Documents/Raquet Studio Projects/");
        public static string templatePath = Path.Combine(resourcesPath, "Template.zip");
        public static string mingw64Path = @"C:\msys64\mingw64.exe";

        public static string currentProjectPath = String.Empty;
        public static Dictionary<string, string> scriptPaths = new Dictionary<string, string>();
        
        static PrivateFontCollection coolFontCol = new PrivateFontCollection();
        static string coolFontDir = Path.Combine(resourcesPath, "CoolFont.ttf");
        static FontFamily coolFontFam;
        public static Font coolFont;
        
        static ProjectUtil()
        {
            coolFontCol.AddFontFile(coolFontDir);
            coolFontFam = new FontFamily("BigBlueTerm437 Nerd Font Mono", coolFontCol);
            coolFont = new Font(coolFontFam, coolFontFam.GetEmHeight(FontStyle.Regular));
        }
    }
}
