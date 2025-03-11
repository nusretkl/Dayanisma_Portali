using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DayanismaPortali.Service.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "il",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_il", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ilId = table.Column<int>(type: "int", nullable: true),
                    Puan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kullanici_il_ilId",
                        column: x => x.ilId,
                        principalTable: "il",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Vakif",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    il_ID = table.Column<int>(type: "int", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ilID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vakif", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vakif_il_ilID",
                        column: x => x.ilID,
                        principalTable: "il",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Randevu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici_ID = table.Column<int>(type: "int", nullable: true),
                    Vakif_ID = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yapildi_mi = table.Column<bool>(type: "bit", nullable: false),
                    kullaniciID = table.Column<int>(type: "int", nullable: false),
                    vakifID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Randevu_Kullanici_kullaniciID",
                        column: x => x.kullaniciID,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevu_Vakif_vakifID",
                        column: x => x.vakifID,
                        principalTable: "Vakif",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_ilId",
                table: "Kullanici",
                column: "ilId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_kullaniciID",
                table: "Randevu",
                column: "kullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_vakifID",
                table: "Randevu",
                column: "vakifID");

            migrationBuilder.CreateIndex(
                name: "IX_Vakif_ilID",
                table: "Vakif",
                column: "ilID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevu");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "Vakif");

            migrationBuilder.DropTable(
                name: "il");
        }
    }
}
