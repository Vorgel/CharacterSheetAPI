using CharacterSheetAPI.Enums;

namespace CharacterSheetAPI.Models
{
    public class Armor
    {
        public int ArmorID { get; set; }

        public int CharacterID { get; set; }

        public string Name { get; set; }

        public BodyParts BodyPart { get; set; }

        public short? Weight { get; set; }

        public short ArmorPoints { get; set; }

        //public List<string>? Features { get; set; }
    }
}