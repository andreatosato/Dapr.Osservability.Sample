using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Osservability.ReaderSecondary.Migrations
{
    public partial class VegetableCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vegetables",
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
                    table.PrimaryKey("PK_Vegetables", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vegetables",
                columns: new[] { "Id", "Description", "ExpirationDate", "Name", "Quantity", "Temperature" },
                values: new object[] { 1, "Upright habit with attractive pier green leaves with crisp costa. Voluminous and heavy head, but well conformed. The great rusticity, even in critical periods, the resistance to the ascent to seed and over-ripening, allow the maximum elasticity of collection, ensuring a quality product, even during the summer. In the kitchen it is used for very fresh single salads with vinegar and a pinch of oil or mixed with cherry tomatoes and corn.", new DateTime(2021, 8, 25, 4, 33, 7, 328, DateTimeKind.Utc).AddTicks(6271), "Lattuga Romana", 100, 10m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vegetables");
        }
    }
}
