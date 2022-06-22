namespace CharacterSheetAPI.Models
{
    public class Wealth
    {
        public int WealthID { get; set; }

        public int CharacterID { get; set; }

        public short Gold { get; set; }

        public short Silver { get; set; }

        public short Bronze { get; set; }
    }
}