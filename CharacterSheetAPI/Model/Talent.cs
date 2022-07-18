namespace CharacterSheetAPI.Models
{
    public class Talent : IStatistic
    {
        public int TalentID { get; set; }

        public int CharacterID { get; set; }

        public string Name { get; set; }

        public short Level { get; set; }

        public string? Description { get; set; }
    }
}
