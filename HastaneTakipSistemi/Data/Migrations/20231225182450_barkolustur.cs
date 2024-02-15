using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneTakipSistemi.Data.Migrations
{
    public partial class barkolustur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "barkodOlusturs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tcNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EngelDurumu = table.Column<bool>(type: "bit", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    BarkodNumarasi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_barkodOlusturs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "barkodOlusturs");
        }
    }
}
