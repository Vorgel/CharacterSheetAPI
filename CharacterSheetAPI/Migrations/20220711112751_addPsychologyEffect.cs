using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class addPsychologyEffect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PsychologyEffect",
                columns: table => new
                {
                    PsychologyEffectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PsychologyEffect", x => x.PsychologyEffectID);
                    table.ForeignKey(
                        name: "FK_PsychologyEffect_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroStats_CharacterID",
                table: "HeroStats",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PsychologyEffect_CharacterID",
                table: "PsychologyEffect",
                column: "CharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_HeroStats_Characters_CharacterID",
                table: "HeroStats",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroStats_Characters_CharacterID",
                table: "HeroStats");

            migrationBuilder.DropTable(
                name: "PsychologyEffect");

            migrationBuilder.DropIndex(
                name: "IX_HeroStats_CharacterID",
                table: "HeroStats");
        }
    }
}
