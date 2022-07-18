using CharacterSheetAPI.Models;

namespace CharacterSheetAPI.Model
{
    public class Character
    {
        public int CharacterID { get; set; }

        public string Name { get; set; }

        public string Race { get; set; }

        public string Class { get; set; }

        public string? Profession { get; set; }

        public string? ProfessionLevel { get; set; }

        public string? ProfessionPath { get; set; }

        public string? Status { get; set; }

        public short? Age { get; set; }

        public List<Characteristics>? Characteristics { get; set; }

        public List<Skill>? Skills { get; set; }

        public short? CorruptionPoints { get; set; }

        public short? SinPoints { get; set; }

        public Appearance? Appearance { get; set; }

        public HeroStats? HeroStats { get; set; }

        public Experience? Experience { get; set; }

        public Speed? Speed { get; set; }

        public List<Talent>? Talents { get; set; }

        public Team? Team { get; set; }

        //public Ambition? Ambitions { get; set; }

        public List<Armor>? Armor { get; set; }

        public List<Equipment>? Equipments { get; set; }

        public Destiny? Destiny { get; set; }

        public List<PsychologyEffect>? PsychologyEffects { get; set; }

        public Wealth? Wealth { get; set; }

        public Vitality? Vitality { get; set; }

        public List<Weapon>? Weapons { get; set; }

        public List<Incantation>? Incantations { get; set; }
    }
}
