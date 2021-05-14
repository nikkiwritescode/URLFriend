using System.Drawing;
using System.Windows.Forms;
using URLfriend.Theme;

namespace URLfriend.UI
{
    public static class FileListLogic
    {
        private static Color bgColor;
        private static Color bgAltColor;
        private static Color selectionColor;
        private static Color textColor;
        private static Color textDisabledColor;
        private static Color positive;
        private static Color negative;
        private static Color regular;
        private static Color selectedTextColor;
        private static bool lvEditMode = false;

        public static void FileNameList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if (ThemeUtils.CurrentPalette != null)
            {
                var palette = ThemeUtils.CurrentPalette;
                bgColor = palette.FileListViewBackgroundColor.GetColor();
                bgAltColor = palette.FileListViewBackgroundColorAlt.GetColor();
                selectionColor = palette.ListViewSelectionColor.GetColor();
                textColor = palette.TextColor.GetColor();
                positive = palette.PositiveColor.GetColor();
                negative = palette.NegativeColor.GetColor();
                regular = palette.TextColor.GetColor();
                selectedTextColor = palette.TextSelectedColor.GetColor();
            }

            var lView = sender as ListView;

            if (lvEditMode || lView.View == View.Details) return;
            var flags = GetTextAlignment(lView, 0);
            var itemColor = e.Item.ForeColor;

            if (e.Item.Selected)
            {
                using (var bkBrush = new SolidBrush(selectionColor)) { e.Graphics.FillRectangle(bkBrush, e.Bounds); }
                itemColor = e.Item.BackColor;
            }
            else
            {
                switch (e.ItemIndex % 2)
                {
                    case 1:
                        using (var bkBrush = new SolidBrush(bgAltColor)) { e.Graphics.FillRectangle(bkBrush, e.Bounds); }
                        break;
                    case 0:
                        using (var bkBrush = new SolidBrush(bgColor)) { e.Graphics.FillRectangle(bkBrush, e.Bounds); }
                        break;
                }
            }
        }

        public static void FileNameList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (ThemeUtils.CurrentPalette != null)
            {
                var palette = ThemeUtils.CurrentPalette;
                bgColor = palette.FileListViewBackgroundColor.GetColor();
                bgAltColor = palette.FileListViewBackgroundColorAlt.GetColor();
                selectionColor = palette.ListViewSelectionColor.GetColor();
                textColor = palette.TextColor.GetColor();
                textDisabledColor = palette.TextDisabledColor.GetColor();
                selectedTextColor = palette.TextSelectedColor.GetColor();
            }

            var lView = sender as ListView;
            var flags = GetTextAlignment(lView, e.ColumnIndex);

            if (e.Item.Selected && !lvEditMode)
            {
                if (e.ColumnIndex == 0 || lView.FullRowSelect)
                {
                    using var bkgrBrush = new SolidBrush(selectionColor);
                    e.Graphics.FillRectangle(bkgrBrush, e.Bounds);
                }
            }
            else
            {
                switch (e.ItemIndex % 2)
                {
                    case 1:
                        foreach (ListViewItem.ListViewSubItem subitem in e.Item.SubItems) { subitem.BackColor = bgAltColor; }
                        break;
                    case 0:
                        foreach (ListViewItem.ListViewSubItem subitem in e.Item.SubItems) { subitem.BackColor = bgColor; }
                        break;
                }
                e.DrawBackground();
            }

            if (e.Item.Selected)
            {
                textColor = selectedTextColor;
                TextRenderer.DrawText((IDeviceContext)e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, textColor, (TextFormatFlags)flags);
            }
            else
            {
                if (e.SubItem.Text.Contains("Downloading") || e.SubItem.Text.Contains("Completed"))
                {
                    textColor = positive;
                    TextRenderer.DrawText((IDeviceContext)e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, textColor, (TextFormatFlags)flags);
                }
                else if (e.SubItem.Text.Contains("Error") || e.SubItem.Text.Contains("404 Not Found"))
                {
                    textColor = negative;
                    TextRenderer.DrawText((IDeviceContext)e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, textColor, (TextFormatFlags)flags);
                }
                else if (e.SubItem.Text.Contains("Waiting"))
                {
                    textColor = textDisabledColor;
                    var f = e.Item.Font;

                    TextRenderer.DrawText((IDeviceContext)e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, textColor, (TextFormatFlags)flags);
                }
                else
                {
                    textColor = regular;
                    TextRenderer.DrawText((IDeviceContext)e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, textColor, (TextFormatFlags)flags);
                }
            }
        }

        public static void FileNameList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            if (ThemeUtils.CurrentPalette == null) return;
            var palette = ThemeUtils.CurrentPalette;

            // Draw the standard header background.
            Brush brushToUse = new SolidBrush(palette.FileListViewHeaderBackgroundColor.GetColor());
            Brush textBrushToUse = new SolidBrush(palette.TextColor.GetColor());
            e.Graphics.FillRectangle(brushToUse, e.Bounds);

            // Draw the header text.
            using var headerFont = new Font("Verdana", 8, FontStyle.Bold);
            e.Graphics.DrawString(e.Header.Text, headerFont, textBrushToUse, e.Bounds, sf);
            return;
        }


        /// <summary>
        /// Character Reference List View
        /// </summary>
        ///
        public static void CharacterReferenceList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if (ThemeUtils.CurrentPalette != null)
            {
                var palette = ThemeUtils.CurrentPalette;
                bgColor = palette.FileListViewBackgroundColor.GetColor();
                bgAltColor = palette.FileListViewBackgroundColorAlt.GetColor();
                selectionColor = palette.ListViewSelectionColor.GetColor();
                textColor = palette.TextColor.GetColor();
                positive = palette.PositiveColor.GetColor();
                negative = palette.NegativeColor.GetColor();
                regular = palette.TextColor.GetColor();
                selectedTextColor = palette.TextSelectedColor.GetColor();
            }

            var lView = sender as ListView;

            if (lvEditMode || lView.View == View.Details) return;
            var flags = GetTextAlignment(lView, 0);
            var itemColor = e.Item.ForeColor;

            if (e.Item.Selected)
            {
                using (var bkBrush = new SolidBrush(selectionColor)) { e.Graphics.FillRectangle(bkBrush, e.Bounds); }
                itemColor = e.Item.BackColor;
            }
            else
            {
                switch (e.ItemIndex % 2)
                {
                    case 1:
                        using (var bkBrush = new SolidBrush(bgAltColor)) { e.Graphics.FillRectangle(bkBrush, e.Bounds); }
                        break;
                    case 0:
                        using (var bkBrush = new SolidBrush(bgColor)) { e.Graphics.FillRectangle(bkBrush, e.Bounds); }
                        break;
                }
            }
        }

        public static void CharacterReferenceList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (ThemeUtils.CurrentPalette != null)
            {
                var palette = ThemeUtils.CurrentPalette;
                bgColor = palette.FileListViewBackgroundColor.GetColor();
                bgAltColor = palette.FileListViewBackgroundColorAlt.GetColor();
                selectionColor = palette.ListViewSelectionColor.GetColor();
                textColor = palette.TextColor.GetColor();
                textDisabledColor = palette.TextDisabledColor.GetColor();
                selectedTextColor = palette.TextSelectedColor.GetColor();
            }

            var lView = sender as ListView;
            var flags = GetTextAlignment(lView, e.ColumnIndex);

            if (e.Item.Selected && !lvEditMode)
            {
                if (e.ColumnIndex == 0 || lView.FullRowSelect)
                {
                    using var bkgrBrush = new SolidBrush(selectionColor);
                    e.Graphics.FillRectangle(bkgrBrush, e.Bounds);
                }
            }
            else
            {
                switch (e.ItemIndex % 2)
                {
                    case 1:
                        foreach (ListViewItem.ListViewSubItem subitem in e.Item.SubItems) { subitem.BackColor = bgAltColor; }
                        break;
                    case 0:
                        foreach (ListViewItem.ListViewSubItem subitem in e.Item.SubItems) { subitem.BackColor = bgColor; }
                        break;
                }
                e.DrawBackground();
            }

            if (e.Item.Selected)
            {
                textColor = selectedTextColor;
                TextRenderer.DrawText((IDeviceContext)e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, textColor, (TextFormatFlags)flags);
            }
            else
            {
                textColor = regular;
                TextRenderer.DrawText((IDeviceContext)e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, textColor, (TextFormatFlags)flags);
            }
        }

        public static void CharacterReferenceList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            if (ThemeUtils.CurrentPalette == null) return;
            var palette = ThemeUtils.CurrentPalette;

            // Draw the standard header background.
            Brush brushToUse = new SolidBrush(palette.FileListViewHeaderBackgroundColor.GetColor());
            Brush textBrushToUse = new SolidBrush(palette.TextColor.GetColor());
            e.Graphics.FillRectangle(brushToUse, e.Bounds);

            // Draw the header text.
            using var headerFont = new Font("Verdana", 8, FontStyle.Bold);
            e.Graphics.DrawString(e.Header.Text, headerFont, textBrushToUse, e.Bounds, sf);
            return;
        }

        private static TextFormatFlags GetTextAlignment(ListView lstView, int colIndex)
        {
            var flags = (lstView.View == View.Tile) ? (colIndex == 0) ? TextFormatFlags.Default : TextFormatFlags.Bottom : TextFormatFlags.VerticalCenter;

            if (lstView.View == View.Details) flags |= TextFormatFlags.LeftAndRightPadding;
            if (lstView.Columns[colIndex].TextAlign != HorizontalAlignment.Left) 
            {
                flags |= (TextFormatFlags)((int)lstView.Columns[colIndex].TextAlign ^ 3);
            }
            return flags;
        }
    }
}