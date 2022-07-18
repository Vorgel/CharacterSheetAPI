using System.ComponentModel.DataAnnotations;

namespace CharacterSheetAPI.Models
{
    public class Speed : IStatistic
    {
        [Key]
        public int CharacterID { get; set; }

        public short SpeedPoints { get; set; }

        public short WalkPoints { get; set; }

        public short RunPoints { get; set; }
    }
}
