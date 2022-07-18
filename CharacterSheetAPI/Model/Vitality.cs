using System.ComponentModel.DataAnnotations;

namespace CharacterSheetAPI.Models
{
    public class Vitality : IStatistic
    {
        [Key]
        public int CharacterID { get; set; }

        public int HealthPoints { get; set; }

        public int MaxHealthPoints { get; set; }

        //public List<string> Wounds { get; set; }
    }
}