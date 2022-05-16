using Microsoft.EntityFrameworkCore.Migrations;

namespace Bbk.Data.Migrations
{
    public partial class test_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Node",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Node",
                table: "Products");
        }
    }
}
