using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentValidation.Web.Migrations
{
    public partial class Customer_ForBirthDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BithDay",
                table: "Customers",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BithDay",
                table: "Customers");
        }
    }
}
