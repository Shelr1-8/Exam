using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Exam.Migrations
{
    /// <inheritdoc />
    public partial class NewDatabaseLibrary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avtors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Avtor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avtors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ganrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ganr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ganrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vydacnytstvo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vydacnytstvo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vydacnytstvo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Knygas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Knyga = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountPages = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Sobivartist = table.Column<int>(type: "int", nullable: false),
                    CinaDlaProdagy = table.Column<int>(type: "int", nullable: false),
                    Prodovgenna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvtorId = table.Column<int>(type: "int", nullable: false),
                    GanrId = table.Column<int>(type: "int", nullable: false),
                    VydacnytstvoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knygas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Knygas_Avtors_AvtorId",
                        column: x => x.AvtorId,
                        principalTable: "Avtors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Knygas_Ganrs_GanrId",
                        column: x => x.GanrId,
                        principalTable: "Ganrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Knygas_Vydacnytstvo_VydacnytstvoId",
                        column: x => x.VydacnytstvoId,
                        principalTable: "Vydacnytstvo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Avtors",
                columns: new[] { "Id", "Avtor" },
                values: new object[,]
                {
                    { 1, "Boeing 747" },
                    { 2, "Mria" },
                    { 3, "AN 225" }
                });

            migrationBuilder.InsertData(
                table: "Ganrs",
                columns: new[] { "Id", "Ganr" },
                values: new object[,]
                {
                    { 1, "BMW" },
                    { 2, "AUDI" },
                    { 3, "LADA" }
                });

            migrationBuilder.InsertData(
                table: "Vydacnytstvo",
                columns: new[] { "Id", "Vydacnytstvo" },
                values: new object[,]
                {
                    { 1, "AAAA" },
                    { 2, "SSS" },
                    { 3, "DDDDDDD" }
                });

            migrationBuilder.InsertData(
                table: "Knygas",
                columns: new[] { "Id", "AvtorId", "CinaDlaProdagy", "CountPages", "GanrId", "Knyga", "Prodovgenna", "Sobivartist", "VydacnytstvoId", "Year" },
                values: new object[,]
                {
                    { 1, 1, 100000, 1, 1, "Chorna dyra", "yes", 1200, 1, 2020 },
                    { 2, 2, 1000000, 5, 2, "Povorot ne tuda", "no", 12000, 2, 2022 },
                    { 3, 3, 1000000, 10, 3, "Marianskaa vpadina", "yes", 10200, 3, 2024 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Knygas_AvtorId",
                table: "Knygas",
                column: "AvtorId");

            migrationBuilder.CreateIndex(
                name: "IX_Knygas_GanrId",
                table: "Knygas",
                column: "GanrId");

            migrationBuilder.CreateIndex(
                name: "IX_Knygas_VydacnytstvoId",
                table: "Knygas",
                column: "VydacnytstvoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Knygas");

            migrationBuilder.DropTable(
                name: "Avtors");

            migrationBuilder.DropTable(
                name: "Ganrs");

            migrationBuilder.DropTable(
                name: "Vydacnytstvo");
        }
    }
}
