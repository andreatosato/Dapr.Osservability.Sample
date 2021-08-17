using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Osservability.ReaderPrimary.Migrations
{
    public partial class FruitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fruits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperature = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Fruits",
                columns: new[] { "Id", "Description", "ExpirationDate", "Name", "Quantity", "Temperature" },
                values: new object[] { 1, "We pick Fuji Melinda from mid-October onwards, when all the other apples have been picked and the highest peaks of the Trentino valleys are already covered with snow. Staying so long on the plant, it accumulates sugars: a real pleasure for the palate.", new DateTime(2021, 8, 24, 14, 33, 33, 691, DateTimeKind.Utc).AddTicks(2671), "Mela Fuji", 100, 10m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fruits");
        }
    }
}
