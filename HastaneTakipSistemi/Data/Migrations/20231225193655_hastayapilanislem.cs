using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneTakipSistemi.Data.Migrations
{
    public partial class hastayapilanislem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hastaYapilanIslemlers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    barkodId = table.Column<int>(type: "int", nullable: false),
                    barkodOlusturId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hastaYapilanIslemlers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hastaYapilanIslemlers_barkodOlusturs_barkodOlusturId",
                        column: x => x.barkodOlusturId,
                        principalTable: "barkodOlusturs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hastaYapilanIslemlers_barkodOlusturId",
                table: "hastaYapilanIslemlers",
                column: "barkodOlusturId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hastaYapilanIslemlers");
        }
    }
}
