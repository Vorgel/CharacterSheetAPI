namespace CharacterSheetAPI.Models
{
    public class Equipment
    {
        public int EquipmentID { get; set; }

        public int CharacterID { get; set; }

        public string Name { get; set; }

        public short? Weight { get; set; }
    }
}