using Microsoft.EntityFrameworkCore.Migrations;

namespace Adoptex.Data.Migrations
{
    public partial class addAnimalInfotoDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Animal_Info",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Animal_Info");
        }
    }
}
