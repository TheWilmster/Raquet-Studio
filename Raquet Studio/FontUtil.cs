using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Text;
using System.DirectoryServices.ActiveDirectory;
using System.Diagnostics;

namespace Raquet_Studio
{
    internal static class FontUtil
    {
        public static Dictionary<string, Font> fonts = new();

        /*static FontUtil()
        {
            
        }*/

        public static bool LoadFont(string directory, float emSize, FontStyle style)
        {
            if (!File.Exists(directory))
                return false;

            PrivateFontCollection collection = new();
            collection.AddFontFile(directory);
            Font font = new(collection.Families[0], emSize, style);
            fonts.Add(font.Name, font);
            Debug.WriteLine(font.Name);

            return true;
        }

        public static bool LoadFont(string directory, float emSize)
        {
            return LoadFont(directory, emSize, FontStyle.Regular);
        }

        public static bool LoadFont(string directory)
        {
            return LoadFont(directory, 12, FontStyle.Regular);
        }
    }
}
