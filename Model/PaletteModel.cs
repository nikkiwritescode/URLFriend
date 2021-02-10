using System.Drawing;

namespace URLfriend.Model
{
    public class PaletteModel
    {
        public Backgroundcolor BackgroundColor { get; set; }
        public Buttoncolor ButtonColor { get; set; }
        public Buttondisabledcolor ButtonDisabledColor { get; set; }
        public Buttonhovercolor ButtonHoverColor { get; set; }
        public Filelistviewbackgroundcolor FileListViewBackgroundColor { get; set; }
        public Filelistviewbackgroundcoloralt FileListViewBackgroundColorAlt { get; set; }
        public Filelistviewheaderbackgroundcolor FileListViewHeaderBackgroundColor { get; set; }
        public Listviewcolor ListViewColor { get; set; }
        public Listviewselectioncolor ListViewSelectionColor { get; set; }
        public Menubarcolor MenuBarColor { get; set; }
        public Negativecolor NegativeColor { get; set; }
        public Positivecolor PositiveColor { get; set; }
        public Textcolor TextColor { get; set; }
        public Textdisabledcolor TextDisabledColor { get; set; }
        public Textlinkcolor TextLinkColor { get; set; }
        public Textselectedcolor TextSelectedColor { get; set; }
        public Metadata MetaData { get; set; }
    }

    public class ParentColorClass
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int A { get; set; }

        public Color GetColor() { return Color.FromArgb(this.A, this.R, this.G, this.B); }
    }

    public class Backgroundcolor : ParentColorClass { }
    public class Buttoncolor : ParentColorClass { }
    public class Buttondisabledcolor : ParentColorClass { }
    public class Buttonhovercolor : ParentColorClass { }
    public class Filelistviewbackgroundcolor : ParentColorClass { }
    public class Filelistviewbackgroundcoloralt : ParentColorClass { }
    public class Filelistviewheaderbackgroundcolor : ParentColorClass { }
    public class Listviewcolor : ParentColorClass { }
    public class Listviewselectioncolor : ParentColorClass { }
    public class Menubarcolor : ParentColorClass { }
    public class Negativecolor : ParentColorClass { }
    public class Positivecolor : ParentColorClass { }
    public class Textcolor : ParentColorClass { }
    public class Textdisabledcolor : ParentColorClass { }
    public class Textlinkcolor : ParentColorClass { }
    public class Textselectedcolor : ParentColorClass { }

    public class Metadata
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public bool UseLightIcon { get; set; }
    }
};
