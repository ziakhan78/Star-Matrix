using Microsoft.EntityFrameworkCore.Migrations;

namespace StarMatrix.Migrations
{
    public partial class test12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShipLocation_BollardPull_BollardPullId",
                table: "ShipLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipLocation_ClassType_ClassTypeId",
                table: "ShipLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipLocation_EngineHP_EngineHpId",
                table: "ShipLocation");

            migrationBuilder.DropIndex(
                name: "IX_ShipLocation_BollardPullId",
                table: "ShipLocation");

            migrationBuilder.DropIndex(
                name: "IX_ShipLocation_ClassTypeId",
                table: "ShipLocation");

            migrationBuilder.DropIndex(
                name: "IX_ShipLocation_EngineHpId",
                table: "ShipLocation");

            migrationBuilder.DropColumn(
                name: "BollardPullId",
                table: "ShipLocation");

            migrationBuilder.DropColumn(
                name: "ClassTypeId",
                table: "ShipLocation");

            migrationBuilder.DropColumn(
                name: "EngineHpId",
                table: "ShipLocation");

            migrationBuilder.AddColumn<string>(
                name: "BollardPullName",
                table: "Tug",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClassTypeName",
                table: "Tug",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EngineHPName",
                table: "Tug",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BollardPullName",
                table: "Tug");

            migrationBuilder.DropColumn(
                name: "ClassTypeName",
                table: "Tug");

            migrationBuilder.DropColumn(
                name: "EngineHPName",
                table: "Tug");

            migrationBuilder.AddColumn<int>(
                name: "BollardPullId",
                table: "ShipLocation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassTypeId",
                table: "ShipLocation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EngineHpId",
                table: "ShipLocation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShipLocation_BollardPullId",
                table: "ShipLocation",
                column: "BollardPullId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipLocation_ClassTypeId",
                table: "ShipLocation",
                column: "ClassTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipLocation_EngineHpId",
                table: "ShipLocation",
                column: "EngineHpId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShipLocation_BollardPull_BollardPullId",
                table: "ShipLocation",
                column: "BollardPullId",
                principalTable: "BollardPull",
                principalColumn: "BollardPullId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipLocation_ClassType_ClassTypeId",
                table: "ShipLocation",
                column: "ClassTypeId",
                principalTable: "ClassType",
                principalColumn: "ClassTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipLocation_EngineHP_EngineHpId",
                table: "ShipLocation",
                column: "EngineHpId",
                principalTable: "EngineHP",
                principalColumn: "EngineHPId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
