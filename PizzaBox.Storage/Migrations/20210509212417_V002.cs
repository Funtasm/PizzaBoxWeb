using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storage.Migrations
{
    public partial class V002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Password",
                value: "example");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Password",
                value: "example");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customers");
        }
    }
}
