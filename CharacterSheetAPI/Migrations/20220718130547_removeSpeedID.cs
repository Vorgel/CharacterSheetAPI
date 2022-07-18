using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class removeSpeedID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Speeds",
                table: "Speeds");

            migrationBuilder.DropIndex(
                name: "IX_Speeds_CharacterID",
                table: "Speeds");

            migrationBuilder.DropColumn(
                name: "SpeedID",
                table: "Speeds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speeds",
                table: "Speeds",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Speeds",
                table: "Speeds");

            migrationBuilder.AddColumn<int>(
                name: "SpeedID",
                table: "Speeds",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speeds",
                table: "Speeds",
                column: "SpeedID");

            migrationBuilder.CreateIndex(
                name: "IX_Speeds_CharacterID",
                table: "Speeds",
                column: "CharacterID",
                unique: true);
        }
    }
}
