using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarMatrix.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Roles = table.Column<string>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Ipaddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BollardPull",
                columns: table => new
                {
                    BollardPullId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BollardPullName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BollardPull", x => x.BollardPullId);
                });

            migrationBuilder.CreateTable(
                name: "ClassType",
                columns: table => new
                {
                    ClassTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassType", x => x.ClassTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EngineHP",
                columns: table => new
                {
                    EngineHPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EngineHPName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineHP", x => x.EngineHPId);
                });

            migrationBuilder.CreateTable(
                name: "Tug",
                columns: table => new
                {
                    TugId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TugName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tug", x => x.TugId);
                });

            migrationBuilder.CreateTable(
                name: "ShipLocation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TugId = table.Column<int>(nullable: false),
                    BollardPullId = table.Column<int>(nullable: false),
                    EngineHpId = table.Column<int>(nullable: false),
                    ClassType = table.Column<string>(nullable: true),
                    ClassTypeId = table.Column<int>(nullable: false),
                    PresentLocation = table.Column<string>(nullable: false),
                    Availability = table.Column<string>(nullable: false),
                    AvailableLocation = table.Column<string>(nullable: false),
                    Ipaddress = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipLocation_BollardPull_BollardPullId",
                        column: x => x.BollardPullId,
                        principalTable: "BollardPull",
                        principalColumn: "BollardPullId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipLocation_ClassType_ClassTypeId",
                        column: x => x.ClassTypeId,
                        principalTable: "ClassType",
                        principalColumn: "ClassTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipLocation_EngineHP_EngineHpId",
                        column: x => x.EngineHpId,
                        principalTable: "EngineHP",
                        principalColumn: "EngineHPId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipLocation_Tug_TugId",
                        column: x => x.TugId,
                        principalTable: "Tug",
                        principalColumn: "TugId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ShipLocation_TugId",
                table: "ShipLocation",
                column: "TugId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "ShipLocation");

            migrationBuilder.DropTable(
                name: "BollardPull");

            migrationBuilder.DropTable(
                name: "ClassType");

            migrationBuilder.DropTable(
                name: "EngineHP");

            migrationBuilder.DropTable(
                name: "Tug");
        }
    }
}
