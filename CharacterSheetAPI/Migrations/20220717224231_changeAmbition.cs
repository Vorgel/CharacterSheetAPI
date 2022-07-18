using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class changeAmbition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Characteristics_CharacterID",
                table: "Characteristics");

            migrationBuilder.RenameColumn(
                name: "AmbitionsID",
                table: "Ambitions",
                newName: "AmbitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_CharacterID",
                table: "Characteristics",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Characteristics_CharacterID",
                table: "Characteristics");

            migrationBuilder.RenameColumn(
                name: "AmbitionID",
                table: "Ambitions",
                newName: "AmbitionsID");

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_CharacterID",
                table: "Characteristics",
                column: "CharacterID",
                unique: true);
        }
    }
}
