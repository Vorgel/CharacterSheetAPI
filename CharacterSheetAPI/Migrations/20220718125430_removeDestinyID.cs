using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class removeDestinyID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Destinies",
                table: "Destinies");

            migrationBuilder.DropIndex(
                name: "IX_Destinies_CharacterID",
                table: "Destinies");

            migrationBuilder.DropColumn(
                name: "DestinyID",
                table: "Destinies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destinies",
                table: "Destinies",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Destinies",
                table: "Destinies");

            migrationBuilder.AddColumn<int>(
                name: "DestinyID",
                table: "Destinies",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destinies",
                table: "Destinies",
                column: "DestinyID");

            migrationBuilder.CreateIndex(
                name: "IX_Destinies_CharacterID",
                table: "Destinies",
                column: "CharacterID",
                unique: true);
        }
    }
}
