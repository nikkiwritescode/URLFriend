using System;
using System.Windows.Forms;
using URLfriend.Theme;

namespace URLfriend.Panels
{
    public partial class AboutPanel : Form
    {
        public AboutPanel()
        {
            InitializeComponent();
            ApplyAboutPanelTheme();
        }

        private void ApplyAboutPanelTheme()
        {
            if (ThemeUtils.CurrentPalette == null) return;
            var palette = ThemeUtils.CurrentPalette;
            BackColor = palette.BackgroundColor.GetColor();
            ForeColor = palette.TextColor.GetColor();
            linkLabel1.LinkColor = palette.TextLinkColor.GetColor();
            aboutOKButton.BackColor = palette.BackgroundColor.GetColor();
            aboutOKButton.ForeColor = palette.TextColor.GetColor();
            logoLight.Visible = palette.MetaData.UseLightIcon;
            logoDark.Visible = !palette.MetaData.UseLightIcon;
        }

        private void aboutOKButton_Click(object sender, EventArgs e) => Hide();
    }
}
