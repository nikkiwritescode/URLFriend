using System.Drawing;
using System.Windows.Forms;

namespace URLfriend.FileList
{
    public partial class BufferedListView : ListView
    {
        public BufferedListView() { SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true); }

        public void RefreshColors(Color negative, Color positive, Color regular)
        {  //regular isn't just white or black because themes!
            var data = new ListViewItem[Items.Count];
            for (var i = 0; i < Items.Count; i++) { data[i] = Items[i]; }

            Items.Clear();

            foreach (var item in data)
            {
                if (item.SubItems[1].Text.Contains("Downloading") || item.SubItems[1].Text.Contains("Completed")) { item.SubItems[1].ForeColor = positive; }
                else if (item.SubItems[1].Text.Contains("Error") || item.SubItems[1].Text.Contains("404 Not Found")) { item.SubItems[1].ForeColor = negative; }
                else { item.SubItems[1].ForeColor = regular; }

                Items.Add(item);
            }
        }
    }
}