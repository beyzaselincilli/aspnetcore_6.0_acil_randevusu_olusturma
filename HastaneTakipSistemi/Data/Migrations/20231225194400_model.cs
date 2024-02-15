using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneTakipSistemi.Data.Migrations
{
    public partial class model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "cikis",
                table: "hastaYapilanIslemlers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "giris",
                table: "hastaYapilanIslemlers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "tedaviAciklamasi",
                table: "hastaYapilanIslemlers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cikis",
                table: "hastaYapilanIslemlers");

            migrationBuilder.DropColumn(
                name: "giris",
                table: "hastaYapilanIslemlers");

            migrationBuilder.DropColumn(
                name: "tedaviAciklamasi",
                table: "hastaYapilanIslemlers");
        }
    }
}
