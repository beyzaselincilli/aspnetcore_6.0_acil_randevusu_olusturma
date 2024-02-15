using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneTakipSistemi.Data.Migrations
{
    public partial class denemeol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "barkodId",
                table: "hastaYapilanIslemlers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "barkodId",
                table: "hastaYapilanIslemlers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
