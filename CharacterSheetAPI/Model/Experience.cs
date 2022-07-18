using System.ComponentModel.DataAnnotations;

namespace CharacterSheetAPI.Models
{
    public class Experience : IStatistic
    {
        [Key]
        public int CharacterID { get; set; }

        public short Available { get; set; }

        public short Spent { get; set; }
    }
}
