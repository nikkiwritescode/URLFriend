using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URLfriend.IO;
using URLfriend.Model;
using URLfriend.Properties;
using URLfriend.Theme;
using URLfriend.UI;

namespace URLfriend.Panels
{
    public partial class ConfigureRemoveCharacterReferencesPanel : Form
    {
        public ConfigureRemoveCharacterReferencesPanel()
        {
            InitializeComponent();
            if (Settings.Default.CharacterReferenceSettingStatus == null) { InitializeList(); }
            else { InitializeListFromMemory(); }
            ApplyCharacterReferencesTheme();
            // Configure the ListView control for owner-draw and add handlers for the owner-draw events.
            CharacterReferenceListView.OwnerDraw = true;
            CharacterReferenceListView.DrawItem += FileListLogic.CharacterReferenceList_DrawItem;
            CharacterReferenceListView.DrawSubItem += FileListLogic.CharacterReferenceList_DrawSubItem;
            CharacterReferenceListView.DrawColumnHeader += FileListLogic.CharacterReferenceList_DrawColumnHeader;
        }

        private void ApplyCharacterReferencesTheme()
        {
            if (ThemeUtils.CurrentPalette == null) return;
            var palette = ThemeUtils.CurrentPalette;
            BackColor = palette.BackgroundColor.GetColor();
            ForeColor = palette.TextColor.GetColor();
            SaveCharacterReferenceButton.BackColor = palette.ButtonColor.GetColor();
            SaveCharacterReferenceButton.ForeColor = palette.TextColor.GetColor();
            CancelCharacterReferenceButton.BackColor = palette.ButtonColor.GetColor();
            CancelCharacterReferenceButton.ForeColor = palette.TextColor.GetColor();
            ReloadEncodingDefaultsButton.BackColor = palette.ButtonColor.GetColor();
            ReloadEncodingDefaultsButton.ForeColor = palette.TextColor.GetColor();
            EnableSelectedRuleButton.BackColor = palette.ButtonColor.GetColor();
            EnableSelectedRuleButton.ForeColor = palette.TextColor.GetColor();
            DisableSelectedRuleButton.BackColor = palette.ButtonColor.GetColor();
            DisableSelectedRuleButton.ForeColor = palette.TextColor.GetColor();

            CharacterReferenceListView.BackColor = palette.ListViewColor.GetColor();
            CharacterReferenceListView.ForeColor = palette.TextColor.GetColor();
        }

        void InitializeList()
        {
            CharacterReferenceListView.Items.Clear();
            var arr = new string[3];
            var symbolList = JSONHandler.LoadCharacterReferences(Application.StartupPath + "data\\" + "DefaultSymbolList.json");

            foreach (var i in symbolList.SymbolMap)
            {
                arr[0] = "Enabled"; //Status Column
                arr[1] = i.Symbol; //Symbol Column
                arr[2] = i.TextToReplaceItWith; //Text to replace it with Column
                var newItem = new ListViewItem(arr);
                CharacterReferenceListView.Items.Add(newItem);
            }
        }

        void InitializeListFromMemory()
        {
            CharacterReferenceListView.Items.Clear();
            var arr = new string[3];
            for (var i = 0; i < Settings.Default.CharacterReferenceSettingStatus.Length; i++)
            {
                arr[0] = Settings.Default.CharacterReferenceSettingStatus[i] is 0 ? @"Disabled" :
                    Settings.Default.CharacterReferenceSettingStatus[i] is 1 ? @"Enabled" : arr[0];

                arr[1] = Settings.Default.CharacterReferenceSettingSymbol[i]; //Symbol Column
                arr[2] = Settings.Default.CharacterReferenceSettingText[i]; //Text to replace it with Column

                var newItem = new ListViewItem(arr);
                CharacterReferenceListView.Items.Add(newItem);
            }
        }

        void DisableSelectedItem()
        {
            switch (CharacterReferenceListView.SelectedItems.Count)
            {
                case 1:
                    CharacterReferenceListView.SelectedItems[0].SubItems[0].Text = @"Disabled";
                    break;
                case > 1:
                {
                    foreach (ListViewItem item in CharacterReferenceListView.SelectedItems) { item.SubItems[0].Text = @"Disabled"; }
                    break;
                }
            }
        }

        void EnableSelectedItem()
        {
            switch (CharacterReferenceListView.SelectedItems.Count)
            {
                case 1:
                    CharacterReferenceListView.SelectedItems[0].SubItems[0].Text = @"Enabled";
                    break;
                case > 1:
                {
                    foreach (ListViewItem item in CharacterReferenceListView.SelectedItems) { item.SubItems[0].Text = @"Enabled"; }
                    break;
                }
            }
        }

        private void DisableSelectedItemButtonClick(object sender, EventArgs e) => DisableSelectedItem();
        private void EnableSelectedItemButtonClick(object sender, EventArgs e) => EnableSelectedItem();
        private void CancelCharacterReferenceButtonClick(object sender, EventArgs e) => CloseConfigureCharacterReferencesPanel();
        private void CloseConfigureCharacterReferencesPanel()
        {
            CharacterReferenceListView.DrawItem -= FileListLogic.CharacterReferenceList_DrawItem;
            CharacterReferenceListView.DrawSubItem -= FileListLogic.CharacterReferenceList_DrawSubItem;
            CharacterReferenceListView.DrawColumnHeader -= FileListLogic.CharacterReferenceList_DrawColumnHeader;
            Close();
        }

        private void SaveCharacterReferenceButtonClick(object sender, EventArgs e)
        {
            SaveCharacterReferenceData();
            CloseConfigureCharacterReferencesPanel();
        }

        private void SaveCharacterReferenceData()
        {
            var statusList = new List<int>();
            var symbolCollection = new StringCollection();
            var textCollection = new StringCollection();

            for (var i = 0; i < CharacterReferenceListView.Items.Count; i++)
            {
                var status = CharacterReferenceListView.Items[i].SubItems[0].Text;
                var symbol = CharacterReferenceListView.Items[i].SubItems[1].Text;
                var text = CharacterReferenceListView.Items[i].SubItems[2].Text;

                statusList.Add(status == @"Enabled" ? 1 : 0);
                symbolCollection.Add(symbol);
                textCollection.Add(text);
            }

            var statusArray = statusList.ToArray();

            Settings.Default.CharacterReferenceSettingStatus = statusArray;
            Settings.Default.CharacterReferenceSettingSymbol = symbolCollection;
            Settings.Default.CharacterReferenceSettingText = textCollection;
            Settings.Default.Save();
        }

        private void ReloadEncodingDefaultsButton_Click(object sender, EventArgs e)
        {
            InitializeList();
        }
    }
}
