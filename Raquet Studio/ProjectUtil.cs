using System;
using System.Collections.Generic;
using System.Text;

namespace Raquet_Studio
{
    internal static class ProjectUtil
    {
        public static string projectsPath = Path.Combine("C:/Users/", Environment.UserName, "Documents/Raquet Studio Projects/");
        public static string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Template.zip");
        public static string mingw64Path = "C:/msys64/mingw64.exe";

        public static string currentProjectPath = String.Empty;
        public static Dictionary<string, string> scriptPaths = new Dictionary<string, string>();
    }
}
