using CharacterSheetAPI.Enums;

namespace CharacterSheetAPI.Models
{
    public class Skill : IStatistic
    {
        public int SkillID { get; set; }

        public int CharacterID { get; set; }

        public string Name { get; set; }

        public CharacteristicsType Type { get; set; }

        public short BaseValue { get; set; }

        public short ExperienceDevelopedValue { get; set; }

        public short TalentsDevelopedValue { get; set; }

        public short CurrentValue { get; set; }
    }
}
