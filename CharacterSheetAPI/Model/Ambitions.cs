namespace CharacterSheetAPI.Models
{
    public class Ambitions
    {
        public int AmbitionsID { get; set; }

        public int CharacterID { get; set; }

        public string? LongTermAmbition { get; set; }

        public string? ShortTermAmbition { get; set; }
    }
}
