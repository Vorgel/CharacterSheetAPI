using CharacterSheetAPI.Enums;

namespace CharacterSheetAPI.Models
{
    public class Weapon
    {
        public int WeaponID { get; set; }

        public int CharacterID { get; set; }

        public string Name { get; set; }

        public WeaponType Type { get; set; }

        public short Weight { get; set; }

        public RangeType Range { get; set; }

        public short Damage { get; set; }

        //public List<string>? Features { get; set; }
    }
}