using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class AddOtherModelsWorkingNow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appearance_Characters_CharacterID",
                table: "Appearance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appearance",
                table: "Appearance");

            migrationBuilder.RenameTable(
                name: "Appearance",
                newName: "Appearances");

            migrationBuilder.RenameIndex(
                name: "IX_Appearance_CharacterID",
                table: "Appearances",
                newName: "IX_Appearances_CharacterID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appearances",
                table: "Appearances",
                column: "AppearanceID");

            migrationBuilder.CreateTable(
                name: "Ambitions",
                columns: table => new
                {
                    AmbitionsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    LongTermAmbition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortTermAmbition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambitions", x => x.AmbitionsID);
                    table.ForeignKey(
                        name: "FK_Ambitions_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    ArmorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyPart = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<short>(type: "smallint", nullable: true),
                    ArmorPoints = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.ArmorID);
                    table.ForeignKey(
                        name: "FK_Armors_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Destinies",
                columns: table => new
                {
                    DestinyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    DestinyPoints = table.Column<short>(type: "smallint", nullable: false),
                    LuckPoints = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinies", x => x.DestinyID);
                    table.ForeignKey(
                        name: "FK_Destinies_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentID);
                    table.ForeignKey(
                        name: "FK_Equipment_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<short>(type: "smallint", nullable: false),
                    Spent = table.Column<short>(type: "smallint", nullable: false),
                    Sum = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceID);
                    table.ForeignKey(
                        name: "FK_Experiences_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeroStats",
                columns: table => new
                {
                    HeroStatsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    HeroPoints = table.Column<short>(type: "smallint", nullable: false),
                    DeterminationPoints = table.Column<short>(type: "smallint", nullable: false),
                    Motivation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroStats", x => x.HeroStatsID);
                });

            migrationBuilder.CreateTable(
                name: "Incantations",
                columns: table => new
                {
                    IncantationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    IncantationType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpellLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RangeInMeters = table.Column<short>(type: "smallint", nullable: false),
                    TargetsAmount = table.Column<short>(type: "smallint", nullable: false),
                    Duration = table.Column<short>(type: "smallint", nullable: false),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incantations", x => x.IncantationID);
                    table.ForeignKey(
                        name: "FK_Incantations_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speeds",
                columns: table => new
                {
                    SpeedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    SpeedPoints = table.Column<short>(type: "smallint", nullable: false),
                    WalkPoints = table.Column<short>(type: "smallint", nullable: false),
                    RunPoints = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speeds", x => x.SpeedID);
                    table.ForeignKey(
                        name: "FK_Speeds_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Talents",
                columns: table => new
                {
                    TalentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<short>(type: "smallint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talents", x => x.TalentID);
                    table.ForeignKey(
                        name: "FK_Talents_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortTermAmbition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongTermAmbition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                    table.ForeignKey(
                        name: "FK_Teams_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vitalities",
                columns: table => new
                {
                    VitalityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitalities", x => x.VitalityID);
                    table.ForeignKey(
                        name: "FK_Vitalities_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wealths",
                columns: table => new
                {
                    WealthID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<short>(type: "smallint", nullable: false),
                    Silver = table.Column<short>(type: "smallint", nullable: false),
                    Bronze = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wealths", x => x.WealthID);
                    table.ForeignKey(
                        name: "FK_Wealths_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    WeaponID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<short>(type: "smallint", nullable: false),
                    Range = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.WeaponID);
                    table.ForeignKey(
                        name: "FK_Weapons_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ambitions_CharacterID",
                table: "Ambitions",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Armors_CharacterID",
                table: "Armors",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Destinies_CharacterID",
                table: "Destinies",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CharacterID",
                table: "Equipment",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_CharacterID",
                table: "Experiences",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Incantations_CharacterID",
                table: "Incantations",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Speeds_CharacterID",
                table: "Speeds",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Talents_CharacterID",
                table: "Talents",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CharacterID",
                table: "Teams",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vitalities_CharacterID",
                table: "Vitalities",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wealths_CharacterID",
                table: "Wealths",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_CharacterID",
                table: "Weapons",
                column: "CharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appearances_Characters_CharacterID",
                table: "Appearances",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appearances_Characters_CharacterID",
                table: "Appearances");

            migrationBuilder.DropTable(
                name: "Ambitions");

            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "Destinies");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "HeroStats");

            migrationBuilder.DropTable(
                name: "Incantations");

            migrationBuilder.DropTable(
                name: "Speeds");

            migrationBuilder.DropTable(
                name: "Talents");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Vitalities");

            migrationBuilder.DropTable(
                name: "Wealths");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appearances",
                table: "Appearances");

            migrationBuilder.RenameTable(
                name: "Appearances",
                newName: "Appearance");

            migrationBuilder.RenameIndex(
                name: "IX_Appearances_CharacterID",
                table: "Appearance",
                newName: "IX_Appearance_CharacterID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appearance",
                table: "Appearance",
                column: "AppearanceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appearance_Characters_CharacterID",
                table: "Appearance",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
