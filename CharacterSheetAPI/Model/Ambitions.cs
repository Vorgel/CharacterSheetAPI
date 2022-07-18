using System.ComponentModel.DataAnnotations;

namespace CharacterSheetAPI.Models
{
    public class Ambition
    {
        [Key]
        public int CharacterID { get; set; }

        public string? LongTermAmbition { get; set; }

        public string? ShortTermAmbition { get; set; }
    }
}
