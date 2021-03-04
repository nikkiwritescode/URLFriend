using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URLfriend.Properties;
using URLfriend.Theme;

namespace URLfriend.Panels
{
    public partial class ConfigureDoubleSpaceRemovalPanel : Form
    {
        public ConfigureDoubleSpaceRemovalPanel()
        {
            InitializeComponent();
            ApplyTheme();
            if (Settings.Default.RunDoubleSpaceRemovalAdditionalTimes)
            {
                RunMultipleTimesCheckbox.Checked = true;
                RunAdditionalTimesComboBox.SelectedIndex = Settings.Default.NumberOfTimesToRemoveDoubleSpaces - 2;

            }
            else
            {
                RunMultipleTimesCheckbox.Checked = false;
                RunAdditionalTimesComboBox.SelectedIndex = 0;
            }

        }

        private void ApplyTheme()
        {
            if (ThemeUtils.CurrentPalette == null) return;
            var palette = ThemeUtils.CurrentPalette;
            BackColor = palette.BackgroundColor.GetColor();
            ForeColor = palette.TextColor.GetColor();
            RunMultipleTimesCheckbox.BackColor = palette.ButtonColor.GetColor();
            RunMultipleTimesCheckbox.ForeColor = palette.TextColor.GetColor();
            RunAdditionalTimesComboBox.BackColor = palette.ButtonColor.GetColor();
            RunAdditionalTimesComboBox.ForeColor = palette.TextColor.GetColor();
            DescriptionGroupBox.BackColor = palette.ButtonColor.GetColor();
            DescriptionGroupBox.ForeColor = palette.TextColor.GetColor();
            DescriptionLabel.BackColor = palette.ButtonColor.GetColor();
            DescriptionLabel.ForeColor = palette.TextColor.GetColor();
            CancelDoubleSpaceRemovalSettingsButton.BackColor = palette.ButtonColor.GetColor();
            CancelDoubleSpaceRemovalSettingsButton.ForeColor = palette.TextColor.GetColor();
            SaveDoubleSpaceRemovalSettingsButton.BackColor = palette.ListViewColor.GetColor();
            SaveDoubleSpaceRemovalSettingsButton.ForeColor = palette.TextColor.GetColor();
        }

        private void RunMultipleTimesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RunAdditionalTimesComboBox.Enabled = RunMultipleTimesCheckbox.Checked;
        }

        private void SaveDoubleSpaceRemovalSettingsButton_Click(object sender, EventArgs e)
        {
            if (!RunMultipleTimesCheckbox.Checked)
            {
                Settings.Default.NumberOfTimesToRemoveDoubleSpaces = 1;
                Settings.Default.RunDoubleSpaceRemovalAdditionalTimes = false;
            }
            else
            {
                //because index "0" is 2 times, so we add 2 to actually apply the value the user is choosing
                Settings.Default.NumberOfTimesToRemoveDoubleSpaces = RunAdditionalTimesComboBox.SelectedIndex + 2;
                Settings.Default.RunDoubleSpaceRemovalAdditionalTimes = true;
            }

            Close();
        }

        private void CancelDoubleSpaceRemovalSettings_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
