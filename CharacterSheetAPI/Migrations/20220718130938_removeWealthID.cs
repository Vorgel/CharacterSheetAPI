using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterSheetAPI.Migrations
{
    public partial class removeWealthID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Wealths",
                table: "Wealths");

            migrationBuilder.DropIndex(
                name: "IX_Wealths_CharacterID",
                table: "Wealths");

            migrationBuilder.DropColumn(
                name: "WealthID",
                table: "Wealths");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wealths",
                table: "Wealths",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Wealths",
                table: "Wealths");

            migrationBuilder.AddColumn<int>(
                name: "WealthID",
                table: "Wealths",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wealths",
                table: "Wealths",
                column: "WealthID");

            migrationBuilder.CreateIndex(
                name: "IX_Wealths_CharacterID",
                table: "Wealths",
                column: "CharacterID",
                unique: true);
        }
    }
}
