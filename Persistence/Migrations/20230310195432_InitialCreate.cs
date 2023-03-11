using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "firmalar",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OnayDurum = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SiparisBaslangıcSaat = table.Column<TimeSpan>(type: "time", nullable: false),
                    SiparisBitisSaat = table.Column<TimeSpan>(type: "time", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_firmalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "urunler",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    UrunAd = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Stok = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_urunler_firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalSchema: "dbo",
                        principalTable: "firmalar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "siparisler",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    MusteriAd = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SiparisTarih = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 3, 10, 22, 54, 32, 21, DateTimeKind.Local).AddTicks(4150)),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siparisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_siparisler_firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalSchema: "dbo",
                        principalTable: "firmalar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_siparisler_urunler_UrunId",
                        column: x => x.UrunId,
                        principalSchema: "dbo",
                        principalTable: "urunler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_siparisler_FirmaId",
                schema: "dbo",
                table: "siparisler",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_siparisler_UrunId",
                schema: "dbo",
                table: "siparisler",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_urunler_FirmaId",
                schema: "dbo",
                table: "urunler",
                column: "FirmaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "siparisler",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "urunler",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "firmalar",
                schema: "dbo");
        }
    }
}
