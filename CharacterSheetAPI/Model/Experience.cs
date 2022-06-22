namespace CharacterSheetAPI.Models
{
    public class Experience
    {
        public int ExperienceID { get; set; }

        public int CharacterID { get; set; }

        public short Available { get; set; }

        public short Spent { get; set; }

        public short Sum { get; set; }
    }
}
