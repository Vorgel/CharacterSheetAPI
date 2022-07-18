using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class removeAmbitionID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ambitions",
                table: "Ambitions");

            migrationBuilder.DropIndex(
                name: "IX_Ambitions_CharacterID",
                table: "Ambitions");

            migrationBuilder.DropColumn(
                name: "AmbitionID",
                table: "Ambitions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ambitions",
                table: "Ambitions",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
               name: "PK_Ambitions",
               table: "Ambitions");

            migrationBuilder.AddColumn<int>(
                name: "AmbitionID",
                table: "Ambitions",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ambitions",
                table: "Ambitions",
                column: "AmbitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Ambitions_CharacterID",
                table: "Ambitions",
                column: "CharacterID",
                unique: true);
        }
    }
}
