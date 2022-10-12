using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_boolflix.Migrations
{
    public partial class EpisodeClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    SeasonNumber = table.Column<int>(type: "int", nullable: true),
                    TvSerieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_TvSeries_TvSerieId",
                        column: x => x.TvSerieId,
                        principalTable: "TvSeries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_TvSerieId",
                table: "Episodes",
                column: "TvSerieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episodes");
        }
    }
}
