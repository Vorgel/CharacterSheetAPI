using CharacterSheetAPI.Model;
using CharacterSheetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Characteristics> Characteristics { get; set; }

        public DbSet<Ambitions> Ambitions { get; set; }

        public DbSet<Appearance> Appearances { get; set; }

        public DbSet<Armor> Armors { get; set; }

        public DbSet<Destiny> Destinies { get; set; }

        public DbSet<Equipment> Equipment { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<HeroStats> HeroStats { get; set; }

        public DbSet<Incantation> Incantations { get; set; }

        public DbSet<Speed> Speeds { get; set; }

        public DbSet<Talent> Talents { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Vitality> Vitalities { get; set; }

        public DbSet<Wealth> Wealths { get; set; }

        public DbSet<Weapon> Weapons { get; set; }
    }
}
