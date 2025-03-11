using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DayanismaPortali.Service.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ilanId",
                table: "Randevu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ilan_ID",
                table: "Randevu",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ilanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ilanlar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_ilanId",
                table: "Randevu",
                column: "ilanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_ilanlar_ilanId",
                table: "Randevu",
                column: "ilanId",
                principalTable: "ilanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_ilanlar_ilanId",
                table: "Randevu");

            migrationBuilder.DropTable(
                name: "ilanlar");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_ilanId",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "ilanId",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "ilan_ID",
                table: "Randevu");
        }
    }
}
