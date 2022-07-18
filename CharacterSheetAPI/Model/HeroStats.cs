using System.ComponentModel.DataAnnotations;

namespace CharacterSheetAPI.Models
{
    public class HeroStats : IStatistic
    {
        [Key]
        public int CharacterID { get; set; }

        public short HeroPoints { get; set; }

        public short DeterminationPoints { get; set; }

        public string Motivation { get; set; }
    }
}
