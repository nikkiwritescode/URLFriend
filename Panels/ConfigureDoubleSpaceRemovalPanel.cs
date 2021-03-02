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

namespace URLfriend.Panels
{
    public partial class ConfigureDoubleSpaceRemovalPanel : Form
    {
        public ConfigureDoubleSpaceRemovalPanel()
        {
            InitializeComponent();
            if (Settings.Default.RunAdditionalTimes)
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

        private void RunMultipleTimesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RunAdditionalTimesComboBox.Enabled = RunMultipleTimesCheckbox.Checked;
        }

        private void SaveDoubleSpaceRemovalSettingsButton_Click(object sender, EventArgs e)
        {
            if (!RunMultipleTimesCheckbox.Checked)
            {
                Settings.Default.NumberOfTimesToRemoveDoubleSpaces = 0;
                Settings.Default.RunAdditionalTimes = false;
            }
            else
            {
                //because index "0" is 2 times, so we add 2 to actually apply the value the user is choosing
                Settings.Default.NumberOfTimesToRemoveDoubleSpaces = RunAdditionalTimesComboBox.SelectedIndex + 2;
                Settings.Default.RunAdditionalTimes = true;
            }

            Close();
        }

        private void CancelDoubleSpaceRemovalSettings_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
