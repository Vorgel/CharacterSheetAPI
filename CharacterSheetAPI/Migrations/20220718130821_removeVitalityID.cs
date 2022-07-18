using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class removeVitalityID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vitalities",
                table: "Vitalities");

            migrationBuilder.DropIndex(
                name: "IX_Vitalities_CharacterID",
                table: "Vitalities");

            migrationBuilder.DropColumn(
                name: "VitalityID",
                table: "Vitalities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vitalities",
                table: "Vitalities",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vitalities",
                table: "Vitalities");

            migrationBuilder.AddColumn<int>(
                name: "VitalityID",
                table: "Vitalities",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vitalities",
                table: "Vitalities",
                column: "VitalityID");

            migrationBuilder.CreateIndex(
                name: "IX_Vitalities_CharacterID",
                table: "Vitalities",
                column: "CharacterID",
                unique: true);
        }
    }
}
