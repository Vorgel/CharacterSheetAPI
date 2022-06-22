namespace CharacterSheetAPI.Models
{
    public class Destiny
    {
        public int DestinyID { get; set; }

        public int CharacterID { get; set; }

        public short DestinyPoints { get; set; }

        public short LuckPoints { get; set; }
    }
}