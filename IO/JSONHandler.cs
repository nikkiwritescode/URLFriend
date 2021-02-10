using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using URLfriend.Model;

namespace URLfriend.IO
{
    public static class JSONHandler
    {
        public static PaletteModel LoadPaletteData(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show(@"The required theme files cannot be found! The application must now exit.");
            }
            var jsonString = File.ReadAllText(fileName);
            var deserializedJson = JsonSerializer.Deserialize<PaletteModel>(jsonString);
            return deserializedJson;
        }

        public static CharacterReferenceModel LoadCharacterReferences(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show(@"The default Character Reference files could not be found!");
            }
            var jsonString = File.ReadAllText(fileName);
            var deserializedJSON = JsonSerializer.Deserialize<CharacterReferenceModel>(jsonString);
            return deserializedJSON;
        }

        public static void SavePaletteData(PaletteModel palette, string fileName)
        {
            var jsonString = JsonSerializer.Serialize(palette);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
