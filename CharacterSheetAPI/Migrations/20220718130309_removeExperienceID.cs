using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class removeExperienceID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_CharacterID",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "ExperienceID",
                table: "Experiences");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceID",
                table: "Experiences",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences",
                column: "ExperienceID");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_CharacterID",
                table: "Experiences",
                column: "CharacterID",
                unique: true);
        }
    }
}
