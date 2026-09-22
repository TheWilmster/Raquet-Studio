using System;
using System.Collections.Generic;
using System.Drawing.Imaging.Effects;
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
        public static string studioAssetsFolder
        {
            get { return Path.Combine(currentProjectPath, ".raqstdio"); }
        }
        public static Dictionary<string, string> scriptPaths = new Dictionary<string, string>();
        public static Dictionary<string, string> actorPaths = new Dictionary<string, string>();
        public static Dictionary<int, string> dynaFuncs = new Dictionary<int, string>(); // list of generated functions used for actor events n' shit
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

        public static void CheckStudioAssetsFolder()
        {
            if (!Directory.Exists(studioAssetsFolder))
            {
                Directory.CreateDirectory(studioAssetsFolder).Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            else
            {
                new DirectoryInfo(studioAssetsFolder).Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            };

            string[] assetTypes = [
                "Actors",
                "Scenes"
            ];

            foreach (string assetType in assetTypes) {
                string path = Path.Combine(studioAssetsFolder, assetType);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
        }

        public static int FillNextDynaFuncSlot(string path)
        {
            int id = 0;
            while (dynaFuncs.Keys.Contains(id))
            {
                id++;
            }
            dynaFuncs.Add(id, path);
            RegenerateEventsHeader();
            return id;
        }

        public static void RegenerateEventsHeader()
        {
            string dynafuncHeader = string.Empty;
            dynafuncHeader += string.Concat(
                "#ifndef DYNAFUNC_H\n",
                "#define DYNAFUNC_H\n",
                "#include \"Raquet.h\"\n\n",
                "typedef void (* Raquet_Event_Function)(Raquet_Actor *);\n"
            );

            foreach (KeyValuePair<int, string> pair in dynaFuncs)
            {
                int id = pair.Key;
                string eventPath = pair.Value;
                dynafuncHeader += string.Concat("void ", Path.GetFileNameWithoutExtension(eventPath), "(Raquet_Actor * actor);\n");
            }

            dynafuncHeader += "static const Raquet_Event_Function __Raquet_Event_Table[] = {\n";
            int i = 0;
            foreach (KeyValuePair<int, string> pair in dynaFuncs)
            {
                int id = pair.Key;
                string eventPath = pair.Value;

                dynafuncHeader += string.Concat("    [", id, "] = ", Path.GetFileNameWithoutExtension(eventPath)); // HELL of a function name btw "GetFileNameWithoutExtension"

                if (i < (dynaFuncs.Count - 1))
                {
                    dynafuncHeader += ",";
                }
                dynafuncHeader += "\n";
                i++; //forgive me
            }
            dynafuncHeader += "};\n";

            dynafuncHeader += "#endif";

            //MessageBox.Show(dynafuncHeader);

            string includePath = Path.Combine(currentProjectPath, "include", "RaquetStudio", "Raquet_Studio_EventsAutogen.h");
            if (!File.Exists(includePath))
            {
                File.Create(includePath).Close();
            }
            File.WriteAllText(includePath, dynafuncHeader);
        }
    }
}
