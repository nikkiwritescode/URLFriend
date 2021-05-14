using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace URLfriend.UI
{
    public class CustomComboBox : ComboBox
    {
        [DllImport("gdi32.dll")]
        internal static extern IntPtr CreateSolidBrush(int color);

        [DllImport("gdi32.dll")]
        internal static extern int SetBkColor(IntPtr hdc, int color);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {

                case (int)312:
                    _ = SetBkColor(m.WParam, ColorTranslator.ToWin32(this.BackColor));
                    var brush = CreateSolidBrush(ColorTranslator.ToWin32(this.BackColor));
                    m.Result = brush;
                    break;
                default:
                    break;
            }
        }
    }
}
