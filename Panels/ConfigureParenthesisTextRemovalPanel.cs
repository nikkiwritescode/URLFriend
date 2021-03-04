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
using URLfriend.FileList;
using URLfriend.Properties;
using URLfriend.Theme;

namespace URLfriend.Panels
{
    public partial class ConfigureParenthesisTextRemovalPanel : Form
    {
        public ConfigureParenthesisTextRemovalPanel()
        {
            InitializeComponent();
            ApplyTheme();
            // Configure the ListView control for owner-draw and add handlers for the owner-draw events.
            PhraseToPreserveListForParenthesisPanel.OwnerDraw = true;
            PhraseToPreserveListForParenthesisPanel.DrawItem += FileListLogic.CharacterReferenceList_DrawItem;
            PhraseToPreserveListForParenthesisPanel.DrawSubItem += FileListLogic.CharacterReferenceList_DrawSubItem;
            PhraseToPreserveListForParenthesisPanel.DrawColumnHeader += FileListLogic.CharacterReferenceList_DrawColumnHeader;

            PhraseToRemoveListForParenthesisPanel.OwnerDraw = true;
            PhraseToRemoveListForParenthesisPanel.DrawItem += FileListLogic.CharacterReferenceList_DrawItem;
            PhraseToRemoveListForParenthesisPanel.DrawSubItem += FileListLogic.CharacterReferenceList_DrawSubItem;
            PhraseToRemoveListForParenthesisPanel.DrawColumnHeader += FileListLogic.CharacterReferenceList_DrawColumnHeader;

            if (Settings.Default.PhrasesToPreserveFromParenthesis != null)
            {
                foreach (var i in Settings.Default.PhrasesToPreserveFromParenthesis)
                {
                    PhraseToPreserveListForParenthesisPanel.Items.Add(i);
                }
            }

            if (Settings.Default.PhrasesToRemoveFromParenthesis != null)
            {
                foreach (var i in Settings.Default.PhrasesToRemoveFromParenthesis)
                {
                    PhraseToRemoveListForParenthesisPanel.Items.Add(i);
                }
            }
        }

        private void ApplyTheme()
        {
            if (ThemeUtils.CurrentPalette == null) return;
            var palette = ThemeUtils.CurrentPalette;
            BackColor = palette.BackgroundColor.GetColor();
            ForeColor = palette.TextColor.GetColor();
            AddPhraseToPreserveTextBox.BackColor = palette.ButtonColor.GetColor();
            AddPhraseToPreserveTextBox.ForeColor = palette.TextColor.GetColor();
            AddPhraseToPreserveButton.BackColor = palette.ButtonColor.GetColor();
            AddPhraseToPreserveButton.ForeColor = palette.TextColor.GetColor();
            ClearPhraseToPreserveListButton.BackColor = palette.ButtonColor.GetColor();
            ClearPhraseToPreserveListButton.ForeColor = palette.TextColor.GetColor();
            RemovePhraseToPreserveButton.BackColor = palette.ButtonColor.GetColor();
            RemovePhraseToPreserveButton.ForeColor = palette.TextColor.GetColor();
            CloseConfigureTextBetweenParenthesisWindowButton.BackColor = palette.ButtonColor.GetColor();
            CloseConfigureTextBetweenParenthesisWindowButton.ForeColor = palette.TextColor.GetColor();
            PhraseToPreserveLabel.BackColor = palette.ListViewColor.GetColor();
            PhraseToPreserveLabel.ForeColor = palette.TextColor.GetColor();

            PhraseToPreserveListForParenthesisPanel.BackColor = palette.ListViewColor.GetColor();
            PhraseToPreserveListForParenthesisPanel.ForeColor = palette.TextColor.GetColor();

            AddPhraseToRemoveTextBox.BackColor = palette.ButtonColor.GetColor();
            AddPhraseToRemoveTextBox.ForeColor = palette.TextColor.GetColor();
            AddPhraseToRemoveButton.BackColor = palette.ButtonColor.GetColor();
            AddPhraseToRemoveButton.ForeColor = palette.TextColor.GetColor();
            ClearPhraseToRemoveListButton.BackColor = palette.ButtonColor.GetColor();
            ClearPhraseToRemoveListButton.ForeColor = palette.TextColor.GetColor();
            RemovePhraseToRemoveButton.BackColor = palette.ButtonColor.GetColor();
            RemovePhraseToRemoveButton.ForeColor = palette.TextColor.GetColor();
            PhraseToRemoveLabel.BackColor = palette.ListViewColor.GetColor();
            PhraseToRemoveLabel.ForeColor = palette.TextColor.GetColor();

            PhraseToRemoveListForParenthesisPanel.BackColor = palette.ListViewColor.GetColor();
            PhraseToRemoveListForParenthesisPanel.ForeColor = palette.TextColor.GetColor();
        }

        private void CloseConfigureTextBetweenParenthesisWindowButton_Click(object sender, EventArgs e)
        {
            PhraseToPreserveListForParenthesisPanel.DrawItem -= FileListLogic.CharacterReferenceList_DrawItem;
            PhraseToPreserveListForParenthesisPanel.DrawSubItem -= FileListLogic.CharacterReferenceList_DrawSubItem;
            PhraseToPreserveListForParenthesisPanel.DrawColumnHeader -= FileListLogic.CharacterReferenceList_DrawColumnHeader;
            PhraseToRemoveListForParenthesisPanel.DrawItem -= FileListLogic.CharacterReferenceList_DrawItem;
            PhraseToRemoveListForParenthesisPanel.DrawSubItem -= FileListLogic.CharacterReferenceList_DrawSubItem;
            PhraseToRemoveListForParenthesisPanel.DrawColumnHeader -= FileListLogic.CharacterReferenceList_DrawColumnHeader;
            SavePhraseData();
            Close();
        }

        private void AddPhraseButton_Click(object sender, EventArgs e)
        {
            if (AddPhraseToPreserveTextBox.Text == string.Empty)
            {
                MessageBox.Show(@"You must enter a phrase before adding it to the list!");
                return;
            }

            var contain = false;
            foreach (ListViewItem i in PhraseToPreserveListForParenthesisPanel.Items)
            {
                if (i.Text == AddPhraseToPreserveTextBox.Text) { contain = true; }
            }

            if (contain)
            {
                MessageBox.Show(@"The list already contains this phrase!");
                AddPhraseToPreserveTextBox.Text = string.Empty;
                return;
            }

            var item = new ListViewItem(AddPhraseToPreserveTextBox.Text);
            PhraseToPreserveListForParenthesisPanel.Items.Add(item);
            AddPhraseToPreserveTextBox.Text = string.Empty;
        }

        private void ClearPhraseListButton_Click(object sender, EventArgs e)
        {
            PhraseToPreserveListForParenthesisPanel.Items.Clear();
        }

        private void RemovePhraseButton_Click(object sender, EventArgs e)
        {
            if (PhraseToPreserveListForParenthesisPanel.SelectedItems.Count == 0) return;
            foreach (ListViewItem item in PhraseToPreserveListForParenthesisPanel.SelectedItems)
            {
                PhraseToPreserveListForParenthesisPanel.Items.Remove(item);
            }
        }

        private void SavePhraseData()
        {
            var phraseToPreserveCollection = new StringCollection();
            var phraseToRemoveCollection = new StringCollection();

            for (var i = 0; i < PhraseToPreserveListForParenthesisPanel.Items.Count; i++)
            {
                var text = PhraseToPreserveListForParenthesisPanel.Items[i].SubItems[0].Text;
                phraseToPreserveCollection.Add(text);
            }

            for (var i = 0; i < PhraseToRemoveListForParenthesisPanel.Items.Count; i++)
            {
                var text = PhraseToRemoveListForParenthesisPanel.Items[i].SubItems[0].Text;
                phraseToRemoveCollection.Add(text);
            }

            Settings.Default.PhrasesToPreserveFromParenthesis = phraseToPreserveCollection;
            Settings.Default.PhrasesToRemoveFromParenthesis = phraseToRemoveCollection;
            Settings.Default.Save();
        }

        private void AddPhraseToRemoveButton_Click(object sender, EventArgs e)
        {
            if (AddPhraseToRemoveTextBox.Text == string.Empty)
            {
                MessageBox.Show(@"You must enter a phrase before adding it to the list!");
                return;
            }

            var contain = false;
            foreach (ListViewItem i in PhraseToRemoveListForParenthesisPanel.Items)
            {
                if (i.Text == AddPhraseToRemoveTextBox.Text) { contain = true; }
            }

            if (contain)
            {
                MessageBox.Show(@"The list already contains this phrase!");
                AddPhraseToRemoveTextBox.Text = string.Empty;
                return;
            }

            var item = new ListViewItem(AddPhraseToRemoveTextBox.Text);
            PhraseToRemoveListForParenthesisPanel.Items.Add(item);
            AddPhraseToRemoveTextBox.Text = string.Empty;
        }

        private void ClearPhraseToRemoveListButton_Click(object sender, EventArgs e)
        {
            PhraseToRemoveListForParenthesisPanel.Items.Clear();
        }

        private void RemovePhraseToRemoveButton_Click(object sender, EventArgs e)
        {
            if (PhraseToRemoveListForParenthesisPanel.SelectedItems.Count == 0) return;
            foreach (ListViewItem item in PhraseToRemoveListForParenthesisPanel.SelectedItems)
            {
                PhraseToRemoveListForParenthesisPanel.Items.Remove(item);
            }
        }
    }
}
