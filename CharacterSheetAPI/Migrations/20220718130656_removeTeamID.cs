using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class removeTeamID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_CharacterID",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "Teams");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "TeamID",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CharacterID",
                table: "Teams",
                column: "CharacterID",
                unique: true);
        }
    }
}
