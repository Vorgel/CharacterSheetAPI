namespace CharacterSheetAPI.Models
{
    public class HeroStats
    {
        public int HeroStatsID { get; set; }

        public int CharacterID { get; set; }

        public short HeroPoints { get; set; }

        public short DeterminationPoints { get; set; }

        public string Motivation { get; set; }
    }
}
