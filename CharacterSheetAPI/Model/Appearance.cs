using System.ComponentModel.DataAnnotations;

namespace CharacterSheetAPI.Models
{
    public class Appearance : IStatistic
    {
        [Key]
        public int CharacterID { get; set; }

        public short? Height { get; set; }

        public string? HairDescription { get; set; }

        public string? EyesDescription { get; set; }

        public string? BodyDescription { get; set; }

        public string? DistinguishingFeatures { get; set; }
    }
}