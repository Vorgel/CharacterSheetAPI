namespace CharacterSheetAPI.Models
{
    public class PsychologyEffect : IStatistic
    {
        public int PsychologyEffectID { get; set; }

        public int CharacterID { get; set; }

        public string Name { get; set; }
    }
}