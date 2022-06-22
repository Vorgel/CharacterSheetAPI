namespace CharacterSheetAPI.Models
{
    public class Vitality
    {
        public int VitalityID { get; set; }

        public int CharacterID { get; set; }

        public int HealthPoints { get; set; }

        //public List<string> Wounds { get; set; }
    }
}