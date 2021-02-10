namespace URLfriend.Model
{
    public class CharacterReferenceModel
    {
        public Symbolmap[] SymbolMap { get; set; }
    }

    public class Symbolmap
    {
        public string Symbol { get; set; }
        public string TextToReplaceItWith { get; set; }
    }
}
