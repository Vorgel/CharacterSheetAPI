using System.ComponentModel.DataAnnotations;

namespace CharacterSheetAPI.Models
{
    public class Wealth : IStatistic
    {
        [Key]
        public int CharacterID { get; set; }

        public short Gold { get; set; }

        public short Silver { get; set; }

        public short Bronze { get; set; }
    }
}