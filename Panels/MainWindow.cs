using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using URLfriend.FileList;
using URLfriend.IO;
using URLfriend.Properties;
using URLfriend.Theme;

namespace URLfriend.Panels
{
    public partial class MainWindow : Form
    {
        public static ListViewItem CurrentlyDownloadingItem;
        public static Task CurrentTask;

        public bool ClearListButtonEnabled = true; //these will do a manual "disable" of the button since
        public bool ReadFileButtonEnabled = true; //there is apparently no way to customize the look of a
        public bool SetOutputDirectoryButtonEnabled = true; //disabled item in winforms.

        public MainWindow()
        {
            InitializeComponent();
            // Configure the ListView control for owner-draw and add handlers for the owner-draw events.
            FileNameList.OwnerDraw = true;
            FileNameList.DrawItem += FileListLogic.FileNameList_DrawItem;
            FileNameList.DrawSubItem += FileListLogic.FileNameList_DrawSubItem;
            FileNameList.DrawColumnHeader += FileListLogic.FileNameList_DrawColumnHeader;
            CreateThemeMenu();
            if (!DoesTheDefaultThemeExist())
            {
                if (MessageBox.Show(@"Fatal Error: the required theme files could not be found!") == DialogResult.OK) { Application.Exit(); }
            }
            else
            {
                ApplySelectedTheme(Settings.Default.ThemeFile);
                CheckTheMenuItemForTheNewThemeAndDeselectTheOthers();
            }
        }

        private void ReadFileButton_Click(object sender, System.EventArgs e)
        {
            if (!ReadFileButtonEnabled) return;
            ReadFileDialog.Multiselect = true;
            ReadFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ReadFileDialog.ShowDialog() != DialogResult.OK) return;
            FileIO.ReadTextFile(this);
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            if (!ClearListButtonEnabled) return; 
            FileNameList.Items.Clear();
        }

        private void SetOutputDirectoryButton_Click(object sender, EventArgs e)
        {
            if (!SetOutputDirectoryButtonEnabled) { return; } 
            SetOutputDirectoryLabel.Text = ChooseFolder();
        }

        public string ChooseFolder()
        {
            var dialog = new FolderBrowserDialog();
            return dialog.ShowDialog() == DialogResult.OK ? dialog.SelectedPath : null;
        }

        private async void DownloadAllButton_Clicked(object sender, EventArgs e)
        {
            var original = DownloadAllButton.Text;
            await NetIO.InitiateDownload(original, this);
        }

        public void DisableButtons()
        {
            DownloadAllButton.Text = @"Cancel Download";
            ClearListButtonEnabled = false;
            ReadFileButtonEnabled = false;
            SetOutputDirectoryButtonEnabled = false;
            if (ThemeUtils.CurrentPalette == null) return;
            var palette = ThemeUtils.CurrentPalette;
            ReadFileButton.ForeColor = palette.ButtonDisabledColor.GetColor();
            SetOutputDirectoryButton.ForeColor = palette.ButtonDisabledColor.GetColor();
            ClearListButton.ForeColor = palette.ButtonDisabledColor.GetColor();
        }

        public void ChangeAllLaterFileStatusesToWaiting(ListViewItem itemToCompare, ListView.ListViewItemCollection items)
        {
            foreach (ListViewItem item in items)
            {
                if (item.Index > itemToCompare.Index) { item.SubItems[1].Text = @"Waiting"; }
            }
        }

        private void OpenAboutWindow(object? sender, EventArgs e)
        {
            var aboutPanel = new AboutPanel();
            aboutPanel.Show();
        }

        private void ExitApplication(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateThemeMenu()
        {
            var dir = new DirectoryInfo(Application.StartupPath + @"themes\");

            foreach (var file in dir.GetFiles())
            {
                var item = new ToolStripMenuItem(Path.GetFileNameWithoutExtension(file.Name), null, (sender, e) => ApplySelectedTheme(file.Name));
                ThemeMenuItem.DropDownItems.Add(item);
            }

        }

        private void CheckTheMenuItemForTheNewThemeAndDeselectTheOthers()
        {
            if (ThemeUtils.CurrentPalette == null) return;
            foreach (ToolStripMenuItem item in ThemeMenuItem.DropDownItems)
            {
                item.Checked = ThemeUtils.CurrentPalette.MetaData.Name == item.Text;
            }
        }

        private bool DoesTheDefaultThemeExist()
        {
            return ThemeMenuItem.DropDownItems.Cast<ToolStripMenuItem>().Any(item => item.Text + ".json" == Settings.Default.ThemeFile);
        }

        private void ApplySelectedTheme(string filename)
        {
            ThemeUtils.ApplyTheme(JSONHandler.LoadPaletteData(Application.StartupPath + "themes\\" + filename), this);
            CheckTheMenuItemForTheNewThemeAndDeselectTheOthers();
        }

        private void ConfigureCharacterReferencesButton_Click(object sender, EventArgs e)
        {
            var configureCharacterReferencesPanel = new ConfigureRemoveCharacterReferencesPanel();
            configureCharacterReferencesPanel.Show();
        }

        private void ConfigureParenthesisTextRemoval_Click(object sender, EventArgs e)
        {

        }

        private void ConfigureDoubleSpaceRemovalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
