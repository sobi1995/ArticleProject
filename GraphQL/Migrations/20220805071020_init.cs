using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.GraphQL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("72d95bfd-1dac-4bc2-adc1-f28fd43777fd"), "Superman and Lois", 15000 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("7b6bf2e3-5d91-4e75-b62f-7357079acc51"), "Avengers: Endgame", 95000 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("c32cc263-a7af-4fbd-99a0-aceb57c91f6b"), "Game of Thrones", 9650000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
