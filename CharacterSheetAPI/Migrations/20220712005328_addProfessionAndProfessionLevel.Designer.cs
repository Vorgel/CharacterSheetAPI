﻿// <auto-generated />
using System;
using CharacterSheetAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220712005328_addProfessionAndProfessionLevel")]
    partial class addProfessionAndProfessionLevel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CharacterSheetAPI.Model.Character", b =>
                {
                    b.Property<int>("CharacterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterID"), 1L, 1);

                    b.Property<short?>("Age")
                        .HasColumnType("smallint");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("CorruptionPoints")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfessionLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfessionPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("SinPoints")
                        .HasColumnType("smallint");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacterID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CharacterSheetAPI.Model.PsychologyEffect", b =>
                {
                    b.Property<int>("PsychologyEffectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PsychologyEffectID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PsychologyEffectID");

                    b.HasIndex("CharacterID");

                    b.ToTable("PsychologyEffect");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Ambitions", b =>
                {
                    b.Property<int>("AmbitionsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AmbitionsID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<string>("LongTermAmbition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortTermAmbition")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AmbitionsID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Ambitions");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Appearance", b =>
                {
                    b.Property<int>("AppearanceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppearanceID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<string>("EyesDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HairDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Height")
                        .HasColumnType("smallint");

                    b.HasKey("AppearanceID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Appearances");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Armor", b =>
                {
                    b.Property<int>("ArmorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArmorID"), 1L, 1);

                    b.Property<short>("ArmorPoints")
                        .HasColumnType("smallint");

                    b.Property<int>("BodyPart")
                        .HasColumnType("int");

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Weight")
                        .HasColumnType("smallint");

                    b.HasKey("ArmorID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Armors");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Characteristics", b =>
                {
                    b.Property<int>("CharacteristicsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacteristicsID"), 1L, 1);

                    b.Property<short>("BaseValue")
                        .HasColumnType("smallint");

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<short>("CurrentValue")
                        .HasColumnType("smallint");

                    b.Property<short>("ExperienceDevelopedValue")
                        .HasColumnType("smallint");

                    b.Property<short>("TalentsDevelopedValue")
                        .HasColumnType("smallint");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("CharacteristicsID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Characteristics");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Destiny", b =>
                {
                    b.Property<int>("DestinyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinyID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<short>("DestinyPoints")
                        .HasColumnType("smallint");

                    b.Property<short>("LuckPoints")
                        .HasColumnType("smallint");

                    b.HasKey("DestinyID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Destinies");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Equipment", b =>
                {
                    b.Property<int>("EquipmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Weight")
                        .HasColumnType("smallint");

                    b.HasKey("EquipmentID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExperienceID"), 1L, 1);

                    b.Property<short>("Available")
                        .HasColumnType("smallint");

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<short>("Spent")
                        .HasColumnType("smallint");

                    b.HasKey("ExperienceID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.HeroStats", b =>
                {
                    b.Property<int>("HeroStatsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HeroStatsID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<short>("DeterminationPoints")
                        .HasColumnType("smallint");

                    b.Property<short>("HeroPoints")
                        .HasColumnType("smallint");

                    b.Property<string>("Motivation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HeroStatsID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("HeroStats");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Incantation", b =>
                {
                    b.Property<int>("IncantationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncantationID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<short>("Duration")
                        .HasColumnType("smallint");

                    b.Property<string>("Effect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncantationType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("RangeInMeters")
                        .HasColumnType("smallint");

                    b.Property<string>("SpellLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("TargetsAmount")
                        .HasColumnType("smallint");

                    b.HasKey("IncantationID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Incantations");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Skill", b =>
                {
                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillID"), 1L, 1);

                    b.Property<short>("BaseValue")
                        .HasColumnType("smallint");

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<short>("CurrentValue")
                        .HasColumnType("smallint");

                    b.Property<short>("ExperienceDevelopedValue")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("TalentsDevelopedValue")
                        .HasColumnType("smallint");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("SkillID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Speed", b =>
                {
                    b.Property<int>("SpeedID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpeedID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<short>("RunPoints")
                        .HasColumnType("smallint");

                    b.Property<short>("SpeedPoints")
                        .HasColumnType("smallint");

                    b.Property<short>("WalkPoints")
                        .HasColumnType("smallint");

                    b.HasKey("SpeedID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Speeds");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Talent", b =>
                {
                    b.Property<int>("TalentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TalentID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Level")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TalentID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Talents");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<string>("LongTermAmbition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortTermAmbition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Vitality", b =>
                {
                    b.Property<int>("VitalityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VitalityID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<int>("HealthPoints")
                        .HasColumnType("int");

                    b.HasKey("VitalityID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Vitalities");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Wealth", b =>
                {
                    b.Property<int>("WealthID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WealthID"), 1L, 1);

                    b.Property<short>("Bronze")
                        .HasColumnType("smallint");

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<short>("Gold")
                        .HasColumnType("smallint");

                    b.Property<short>("Silver")
                        .HasColumnType("smallint");

                    b.HasKey("WealthID");

                    b.HasIndex("CharacterID")
                        .IsUnique();

                    b.ToTable("Wealths");
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Weapon", b =>
                {
                    b.Property<int>("WeaponID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeaponID"), 1L, 1);

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<short>("Damage")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Range")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<short>("Weight")
                        .HasColumnType("smallint");

                    b.HasKey("WeaponID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("CharacterSheetAPI.Model.PsychologyEffect", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithMany("PsychologyEffects")
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Ambitions", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithOne("Ambitions")
                        .HasForeignKey("CharacterSheetAPI.Models.Ambitions", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Appearance", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithOne("Appearance")
                        .HasForeignKey("CharacterSheetAPI.Models.Appearance", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Armor", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithMany("Armor")
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Characteristics", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithOne("Characteristics")
                        .HasForeignKey("CharacterSheetAPI.Models.Characteristics", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Destiny", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithOne("Destiny")
                        .HasForeignKey("CharacterSheetAPI.Models.Destiny", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Equipment", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithMany("Equipments")
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Experience", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithOne("Experience")
                        .HasForeignKey("CharacterSheetAPI.Models.Experience", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.HeroStats", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithOne("HeroStats")
                        .HasForeignKey("CharacterSheetAPI.Models.HeroStats", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Incantation", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithMany("Incantations")
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Skill", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithMany("Skills")
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Speed", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithOne("Speed")
                        .HasForeignKey("CharacterSheetAPI.Models.Speed", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Talent", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithMany("Talents")
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Team", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithOne("Team")
                        .HasForeignKey("CharacterSheetAPI.Models.Team", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Vitality", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithOne("Vitality")
                        .HasForeignKey("CharacterSheetAPI.Models.Vitality", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Wealth", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithOne("Wealth")
                        .HasForeignKey("CharacterSheetAPI.Models.Wealth", "CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Models.Weapon", b =>
                {
                    b.HasOne("CharacterSheetAPI.Model.Character", null)
                        .WithMany("Weapons")
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSheetAPI.Model.Character", b =>
                {
                    b.Navigation("Ambitions");

                    b.Navigation("Appearance");

                    b.Navigation("Armor");

                    b.Navigation("Characteristics");

                    b.Navigation("Destiny");

                    b.Navigation("Equipments");

                    b.Navigation("Experience");

                    b.Navigation("HeroStats");

                    b.Navigation("Incantations");

                    b.Navigation("PsychologyEffects");

                    b.Navigation("Skills");

                    b.Navigation("Speed");

                    b.Navigation("Talents");

                    b.Navigation("Team");

                    b.Navigation("Vitality");

                    b.Navigation("Wealth");

                    b.Navigation("Weapons");
                });
#pragma warning restore 612, 618
        }
    }
}
