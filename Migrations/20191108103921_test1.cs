using Microsoft.EntityFrameworkCore.Migrations;

namespace StarMatrix.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassType",
                table: "ShipLocation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassType",
                table: "ShipLocation",
                nullable: true);
        }
    }
}
