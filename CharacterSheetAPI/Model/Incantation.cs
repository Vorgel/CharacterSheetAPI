using CharacterSheetAPI.Enums;

namespace CharacterSheetAPI.Models
{
    public class Incantation
    {
        public int IncantationID { get; set; }

        public int CharacterID { get; set; }

        public IncantationType IncantationType { get; set; }

        public string Name { get; set; }

        public string? SpellLevel { get; set; }

        public short RangeInMeters { get; set; }

        public short TargetsAmount { get; set; }

        public short Duration { get; set; }

        public string Effect { get; set; }
    }
}