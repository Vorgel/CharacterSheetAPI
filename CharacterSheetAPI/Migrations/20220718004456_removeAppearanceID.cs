using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class removeAppearanceID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Appearances",
                table: "Appearances");

            migrationBuilder.DropIndex(
                name: "IX_Appearances_CharacterID",
                table: "Appearances");

            migrationBuilder.DropColumn(
                name: "AppearanceID",
                table: "Appearances");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appearances",
                table: "Appearances",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Appearances",
                table: "Appearances");

            migrationBuilder.AddColumn<int>(
                name: "AppearanceID",
                table: "Appearances",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appearances",
                table: "Appearances",
                column: "AppearanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Appearances_CharacterID",
                table: "Appearances",
                column: "CharacterID",
                unique: true);
        }
    }
}
