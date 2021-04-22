using Microsoft.EntityFrameworkCore.Migrations;

namespace Videostore.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_ReleaseDates_releaseDateID",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "ReleaseDates");

            migrationBuilder.DropIndex(
                name: "IX_Movies_releaseDateID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "releaseDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "releaseDateID",
                table: "Movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "releaseDate",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "releaseDateID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ReleaseDates",
                columns: table => new
                {
                    releaseDateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    releaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseDates", x => x.releaseDateID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_releaseDateID",
                table: "Movies",
                column: "releaseDateID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_ReleaseDates_releaseDateID",
                table: "Movies",
                column: "releaseDateID",
                principalTable: "ReleaseDates",
                principalColumn: "releaseDateID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
