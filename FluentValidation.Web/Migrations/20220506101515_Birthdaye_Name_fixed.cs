using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentValidation.Web.Migrations
{
    public partial class Birthdaye_Name_fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BithDay",
                table: "Customers",
                newName: "BirthDay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "Customers",
                newName: "BithDay");
        }
    }
}
