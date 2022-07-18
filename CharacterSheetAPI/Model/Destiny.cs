using System.ComponentModel.DataAnnotations;

namespace CharacterSheetAPI.Models
{
    public class Destiny : IStatistic
    {
        [Key]
        public int CharacterID { get; set; }

        public short DestinyPoints { get; set; }

        public short LuckPoints { get; set; }
    }
}