namespace CharacterSheetAPI.Models
{
    public class Team
    {
        public int TeamID { get; set; }

        public int CharacterID { get; set; }

        public string Name { get; set; }

        public string ShortTermAmbition { get; set; }

        public string LongTermAmbition { get; set; }
    }
}
