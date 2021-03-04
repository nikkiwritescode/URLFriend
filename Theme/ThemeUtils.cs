using System.Collections.Generic;
using System.Windows.Forms;
using URLfriend.Model;
using URLfriend.Panels;
using URLfriend.Properties;

namespace URLfriend.Theme
{
    public static class ThemeUtils
    {
        public static PaletteModel CurrentPalette;

        public static void ApplyTheme(PaletteModel palette, MainWindow window)
        {
            SetMenuItemsTheme(palette, window);
            SetGroupBoxColorTheme(palette, window);
            SetWindowColorTheme(palette, window);
            SetButtonColorTheme(palette, window);
            SetListViewColorTheme(palette, window);
            SetMenuStripTheme(palette, window);
            CurrentPalette = palette;
            Settings.Default.ThemeFile = palette.MetaData.FileName;
            Settings.Default.Save();
        }

        private static void SetWindowColorTheme(PaletteModel palette, MainWindow window)
        {
            window.BackColor = palette.BackgroundColor.GetColor(); 
            window.ForeColor = palette.TextColor.GetColor();
        }

        private static void SetGroupBoxColorTheme(PaletteModel palette, MainWindow window)
        {
            window.groupBoxConfigureOutput.BackColor = palette.BackgroundColor.GetColor();
            window.groupBoxConfigureOutput.ForeColor = palette.TextColor.GetColor();
            window.groupBoxFileNamePadding.BackColor = palette.BackgroundColor.GetColor();
            window.groupBoxFileNamePadding.ForeColor = palette.TextColor.GetColor();
        }

        private static void SetMenuStripTheme(PaletteModel palette, MainWindow window)
        {
            window.menuStrip1.BackColor = palette.MenuBarColor.GetColor();
            window.menuStrip1.ForeColor = palette.TextColor.GetColor();
            window.FileMenuItem.BackColor = palette.MenuBarColor.GetColor();
            window.FileMenuItem.ForeColor = palette.TextColor.GetColor();
            window.OptionsMenuItem.BackColor = palette.MenuBarColor.GetColor();
            window.OptionsMenuItem.ForeColor = palette.TextColor.GetColor();
            window.HelpMenuItem.BackColor = palette.MenuBarColor.GetColor();
            window.HelpMenuItem.ForeColor = palette.TextColor.GetColor();
        }

        private static void SetMenuItemsTheme(PaletteModel palette, MainWindow window)
        {
            window.ThemeMenuItem.BackColor = palette.MenuBarColor.GetColor();
            window.ThemeMenuItem.ForeColor = palette.TextColor.GetColor();
            window.ExitMenuItem.BackColor = palette.MenuBarColor.GetColor();
            window.ExitMenuItem.ForeColor = palette.TextColor.GetColor();
            window.AboutMenuItem.BackColor = palette.MenuBarColor.GetColor();
            window.AboutMenuItem.ForeColor = palette.TextColor.GetColor();
            /*window.NavyThemeMenuItem.BackColor = palette.MenuBarColor.GetColor();
            window.NavyThemeMenuItem.ForeColor = palette.TextColor.GetColor();
            window.NightThemeMenuItem.BackColor = palette.MenuBarColor.GetColor();
            window.NightThemeMenuItem.ForeColor = palette.TextColor.GetColor();*/
        }

        private static void SetButtonColorTheme(PaletteModel palette, MainWindow window)
        {
            var buttons = new List<Button>
            {
                window.ClearListButton,
                window.ReadFileButton,
                window.SetOutputDirectoryButton,
                window.DownloadAllButton,
                window.ConfigureCharacterReferencesButton,
                window.ConfigureDoubleSpaceRemovalButton,
                window.ConfigureParenthesisTextHandlingButton
            };

            foreach (var b in buttons)
            {
                b.BackColor = palette.ButtonColor.GetColor();
                b.ForeColor = IsButtonAllowed(b, window) ? palette.TextColor.GetColor() : palette.TextDisabledColor.GetColor();
            }
        }

        private static bool IsButtonAllowed(Button b, MainWindow window)
        {
            if (b.Name == "ClearListButton" && window.ClearListButtonEnabled ||
                b.Name == "ReadFileButton" && window.ReadFileButtonEnabled ||
                b.Name == "SetOutputDirectoryButton" && window.SetOutputDirectoryButtonEnabled ||
                b.Name == "DownloadAllButton")
            {
                return true;
            }
            else { return false; }
        }

        private static void SetListViewColorTheme(PaletteModel palette, MainWindow window)
        {
            window.FileNameList.BackColor = palette.ListViewColor.GetColor(); 
            window.FileNameList.ForeColor = palette.TextColor.GetColor();
        }

        public static void HoverLeave(object? o, System.EventArgs e)
        {
            switch (o.GetType().Name)
            {
                case "Button":
                    ApplyHoverLeaveColor((Control)o, null);
                    break;
                case "ToolStripMenuItem":
                    ApplyHoverLeaveColor(null, (ToolStripMenuItem)o);
                    break;
            }
        }

        private static void ApplyHoverLeaveColor(Control? control, ToolStripMenuItem? toolStripItem)
        {
            if (CurrentPalette == null) return;
            
                if (control != null)
                {
                    control.BackColor = CurrentPalette.ButtonColor.GetColor();
                    control.ForeColor = CurrentPalette.TextColor.GetColor();
                }

                if (toolStripItem != null)
                {
                    toolStripItem.BackColor = CurrentPalette.MenuBarColor.GetColor();
                    toolStripItem.ForeColor = CurrentPalette.TextColor.GetColor();
                }
        }

        public static void HoverEnter(object o, System.EventArgs e)
        {
            switch (o.GetType().Name)
            {
                case "Button":
                    ApplyHoverEnterColor((Control)o, null);
                    break;
                case "ToolStripMenuItem":
                    ApplyHoverEnterColor(null, (ToolStripMenuItem)o);
                    break;
            }
        }

        private static void ApplyHoverEnterColor(Control? control, ToolStripMenuItem? toolStripItem)
        {
            /*switch (lightModeEnabled)
            {
                case true:
                    {
                        if (control != null && toolStripItem == null)
                        {
                            /*control.BackColor = _lightButtonHoverColor;
                            control.ForeColor = _lightTextColor;#1#
                            break;
                        }

                        if (control == null && toolStripItem != null)
                        {
                            toolStripItem.BackColor = _lightButtonHoverColor;
                            toolStripItem.ForeColor = _lightTextColor;
                            break;
                        }

                        break;
                    }

                case false:
                    if (control != null && toolStripItem == null)
                    {
                        /*control.BackColor = _darkButtonHoverColor;
                        control.ForeColor = _darkTextColor;
                        break;#1#
                    }

                    if (control == null && toolStripItem != null)
                    {
                        toolStripItem.BackColor = _darkTextColor;
                        toolStripItem.ForeColor = _darkButtonHoverColor;
                        break;
                    }
                    break;
            }*/

        }
    }
}