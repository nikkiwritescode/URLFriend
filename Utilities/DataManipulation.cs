using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using URLfriend.Properties;

namespace URLfriend.Utilities
{
    public static class DataManipulation
    {
        public static string RemoveExtraSpacesFromFileName(string filename)
        {
            for (var i = 0; i < Settings.Default.NumberOfTimesToRemoveDoubleSpaces; i++)
            {
                filename = Regex.Replace(filename, @"  ", " "); //two spaces to one
            }
            
            var ext = Path.GetExtension(filename);
            filename = Regex.Replace(filename, @" " + ext, ext); //this removes the space before the file extension
            return filename;
        }

        public static string RemoveCharacterReferencesFromFileName(string filename, string symbol, string textToReplaceItWith)
        {
            if (symbol == "%20")
            {
                textToReplaceItWith = "\u0020";
            }
            var newFilename = Regex.Replace(filename, symbol, textToReplaceItWith);
            return newFilename;
        }

        public static string HandleTextFromInsideParenthesis(string filename)
        {
            var newFile = filename;
            foreach (var i in Settings.Default.PhrasesToPreserveFromParenthesis)
            {
                var beg = "%28";
                var mid = i;
                var end = "%29";

                if (i != null && i.Contains(" ")) { mid = i.Replace(" ", "%20"); }

                newFile = newFile.Replace(beg+mid+end, mid);
            }

            foreach (var i in Settings.Default.PhrasesToRemoveFromParenthesis)
            {
                var beg = "%28";
                var mid = i;
                var end = "%29";

                if (i != null && i.Contains(" ")) { mid = i.Replace(" ", "%20"); }

                newFile = newFile.Replace(beg + mid + end, "");
            }
            return newFile;
        }

        public static int GetPercentage(long value, long total)
        {
            var percent = ((double)value / (double)total) * 100;
            return (int)percent;
        }

        public static float ConvertBytesToKilobytes(long bytes) { return bytes / 1024f; }
        public static float ConvertBytesToMegabytes(long bytes) { return MathF.Round(((bytes / 1024f) / 1024f), 2); }
        public static float ConvertBytesToGigabytes(long bytes) { return MathF.Round((((bytes / 1024f) / 1024f) / 1024f), 3); }
    }
}