namespace CharacterSheetAPI.Models
{
    public class Appearance
    {
        public int AppearanceID { get; set; }

        public int CharacterID { get; set; }

        public short? Height { get; set; }

        public string? HairDescription { get; set; }

        public string? EyesDescription { get; set; }
    }
}