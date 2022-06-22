using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfessionPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<short>(type: "smallint", nullable: true),
                    CorruptionPoints = table.Column<short>(type: "smallint", nullable: true),
                    SinPoints = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterID);
                });

            migrationBuilder.CreateTable(
                name: "Appearance",
                columns: table => new
                {
                    AppearanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<short>(type: "smallint", nullable: true),
                    HairDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EyesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appearance", x => x.AppearanceID);
                    table.ForeignKey(
                        name: "FK_Appearance_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    CharacteristicsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    BaseValue = table.Column<short>(type: "smallint", nullable: false),
                    ExperienceDevelopedValue = table.Column<short>(type: "smallint", nullable: false),
                    TalentsDevelopedValue = table.Column<short>(type: "smallint", nullable: false),
                    CurrentValue = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.CharacteristicsID);
                    table.ForeignKey(
                        name: "FK_Characteristics_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    BaseValue = table.Column<short>(type: "smallint", nullable: false),
                    ExperienceDevelopedValue = table.Column<short>(type: "smallint", nullable: false),
                    TalentsDevelopedValue = table.Column<short>(type: "smallint", nullable: false),
                    CurrentValue = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillID);
                    table.ForeignKey(
                        name: "FK_Skills_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appearance_CharacterID",
                table: "Appearance",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_CharacterID",
                table: "Characteristics",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharacterID",
                table: "Skills",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appearance");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
