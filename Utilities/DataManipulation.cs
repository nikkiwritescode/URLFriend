using System;
using System.Text.RegularExpressions;

namespace URLfriend.Utilities
{
    public static class DataManipulation
    {
        public static string RemoveExtraSpacesFromFileName(string filename)
        {
            filename = Regex.Replace(filename, @"  ", " "); //remove double spaces
            filename = Regex.Replace(filename, @"  ", " "); //running it multiple times to
            filename = Regex.Replace(filename, @"  ", " "); //handle triple, quadruple etc spaces
            filename = Regex.Replace(filename, @" .zip", ".zip"); //removing the additional space before the file extension
            return filename;
        }

        public static string RemoveCharacterReferencesFromFileName(string filename, string symbol, string textToReplaceItWith)
        {
            var newFilename = Regex.Replace(filename, symbol, textToReplaceItWith);
            return newFilename;
        }

        public static string RemoveTextFromInsideParenthesis(string filename, string textToRemoveParenthesisFrom)
        { //might be pointless if the function to remove the parenthesis themselves works
            filename = Regex.Replace(filename, $"({textToRemoveParenthesisFrom})", textToRemoveParenthesisFrom);
            return filename;
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