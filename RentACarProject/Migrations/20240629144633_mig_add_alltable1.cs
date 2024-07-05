using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarProject.Migrations
{
    public partial class mig_add_alltable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryLocations",
                columns: table => new
                {
                    DeliveryLocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryLocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryLocations", x => x.DeliveryLocationId);
                });

            migrationBuilder.CreateTable(
                name: "ForRentCars",
                columns: table => new
                {
                    ForRentCarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarKM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarGearType = table.Column<bool>(type: "bit", nullable: false),
                    CarTotalPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarFuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarRenterPersonMinAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarEnginePower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarDayPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForRentCars", x => x.ForRentCarID);
                });

            migrationBuilder.CreateTable(
                name: "ReceivingLocations",
                columns: table => new
                {
                    ReceivingLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceivingLocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivingLocations", x => x.ReceivingLocationID);
                });

            migrationBuilder.CreateTable(
                name: "RentACars",
                columns: table => new
                {
                    RentACarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForRentCarID = table.Column<int>(type: "int", nullable: false),
                    ReceivingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivingLocationID = table.Column<int>(type: "int", nullable: false),
                    DeliveryLocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentACars", x => x.RentACarID);
                    table.ForeignKey(
                        name: "FK_RentACars_DeliveryLocations_DeliveryLocationId",
                        column: x => x.DeliveryLocationId,
                        principalTable: "DeliveryLocations",
                        principalColumn: "DeliveryLocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentACars_ForRentCars_ForRentCarID",
                        column: x => x.ForRentCarID,
                        principalTable: "ForRentCars",
                        principalColumn: "ForRentCarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentACars_ReceivingLocations_ReceivingLocationID",
                        column: x => x.ReceivingLocationID,
                        principalTable: "ReceivingLocations",
                        principalColumn: "ReceivingLocationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentACars_DeliveryLocationId",
                table: "RentACars",
                column: "DeliveryLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_RentACars_ForRentCarID",
                table: "RentACars",
                column: "ForRentCarID");

            migrationBuilder.CreateIndex(
                name: "IX_RentACars_ReceivingLocationID",
                table: "RentACars",
                column: "ReceivingLocationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentACars");

            migrationBuilder.DropTable(
                name: "DeliveryLocations");

            migrationBuilder.DropTable(
                name: "ForRentCars");

            migrationBuilder.DropTable(
                name: "ReceivingLocations");
        }
    }
}
