using System.ComponentModel.DataAnnotations;

namespace CharacterSheetAPI.Models
{
    public class Team : IStatistic
    {
        [Key]
        public int CharacterID { get; set; }

        public string Name { get; set; }

        public string ShortTermAmbition { get; set; }

        public string LongTermAmbition { get; set; }
    }
}
