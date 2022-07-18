using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class removeHeroStatsID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroStats",
                table: "HeroStats");

            migrationBuilder.DropIndex(
                name: "IX_HeroStats_CharacterID",
                table: "HeroStats");

            migrationBuilder.DropColumn(
                name: "HeroStatsID",
                table: "HeroStats");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroStats",
                table: "HeroStats",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroStats",
                table: "HeroStats");

            migrationBuilder.AddColumn<int>(
                name: "HeroStatsID",
                table: "HeroStats",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroStats",
                table: "HeroStats",
                column: "HeroStatsID");

            migrationBuilder.CreateIndex(
                name: "IX_HeroStats_CharacterID",
                table: "HeroStats",
                column: "CharacterID",
                unique: true);
        }
    }
}
