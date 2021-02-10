using System.IO;
using System.Windows.Forms;
using URLfriend.Panels;
using URLfriend.Properties;
using URLfriend.Utilities;

namespace URLfriend.IO
{
    public static class FileIO
    {
        public static void ReadTextFile(MainWindow window)
        {
            var arr = new string[4];
            var sr = new StreamReader(window.ReadFileDialog.OpenFile());

            while (!sr.EndOfStream)
            {
                var urlPath = sr.ReadLine();

                if (urlPath == null) continue;
                var filename = Path.GetFileName(urlPath);

                if (window.removeParenthesisCheckbox.Checked)
                {
                    filename = DataManipulation.RemoveTextFromInsideParenthesis(filename, "Disc 1");
                }

                if (window.RemoveCharacterReferencesCheckbox.Checked)
                {
                    //foreach every record in the CharacterReferenceModelItem
                    /*var characters = 
                    foreach (var item in )
                    {
                        
                    }*/

                    for (var i = 0; i < Settings.Default.CharacterReferenceSettingStatus.Length; i++)
                    {
                        if (Settings.Default.CharacterReferenceSettingStatus[i] != 1) { } //if it's not active, do nothing
                        else
                        {
                            filename = DataManipulation.RemoveCharacterReferencesFromFileName(filename,
                                Settings.Default.CharacterReferenceSettingSymbol[i], 
                                Settings.Default.CharacterReferenceSettingText[i]);
                        }
                    }
                }

                if (window.RemoveSpacesCheckbox.Checked)
                {
                    filename = DataManipulation.RemoveExtraSpacesFromFileName(filename);
                }

                arr[0] = urlPath;
                arr[1] = "Not started"; //Status column
                arr[2] = "-"; //Progress column
                arr[3] = filename;

                var newItem = new ListViewItem(arr);
                window.FileNameList.Items.Add(newItem);
            }

            sr.Close();
        }
    }
}