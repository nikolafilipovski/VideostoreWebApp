using Microsoft.EntityFrameworkCore.Migrations;

namespace Videostore.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Buys_buyID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Rents_rentID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Watchlists_watchlistID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_TVshows_Buys_buyID",
                table: "TVshows");

            migrationBuilder.DropForeignKey(
                name: "FK_TVshows_Rents_rentID",
                table: "TVshows");

            migrationBuilder.DropForeignKey(
                name: "FK_TVshows_Watchlists_watchlistID",
                table: "TVshows");

            migrationBuilder.AlterColumn<int>(
                name: "watchlistID",
                table: "TVshows",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "rentID",
                table: "TVshows",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "buyID",
                table: "TVshows",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "watchlistID",
                table: "Movies",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "rentID",
                table: "Movies",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "buyID",
                table: "Movies",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Buys_buyID",
                table: "Movies",
                column: "buyID",
                principalTable: "Buys",
                principalColumn: "buyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Rents_rentID",
                table: "Movies",
                column: "rentID",
                principalTable: "Rents",
                principalColumn: "rentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Watchlists_watchlistID",
                table: "Movies",
                column: "watchlistID",
                principalTable: "Watchlists",
                principalColumn: "watchlistID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TVshows_Buys_buyID",
                table: "TVshows",
                column: "buyID",
                principalTable: "Buys",
                principalColumn: "buyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TVshows_Rents_rentID",
                table: "TVshows",
                column: "rentID",
                principalTable: "Rents",
                principalColumn: "rentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TVshows_Watchlists_watchlistID",
                table: "TVshows",
                column: "watchlistID",
                principalTable: "Watchlists",
                principalColumn: "watchlistID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Buys_buyID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Rents_rentID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Watchlists_watchlistID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_TVshows_Buys_buyID",
                table: "TVshows");

            migrationBuilder.DropForeignKey(
                name: "FK_TVshows_Rents_rentID",
                table: "TVshows");

            migrationBuilder.DropForeignKey(
                name: "FK_TVshows_Watchlists_watchlistID",
                table: "TVshows");

            migrationBuilder.AlterColumn<int>(
                name: "watchlistID",
                table: "TVshows",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "rentID",
                table: "TVshows",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "buyID",
                table: "TVshows",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "watchlistID",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "rentID",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "buyID",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Buys_buyID",
                table: "Movies",
                column: "buyID",
                principalTable: "Buys",
                principalColumn: "buyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Rents_rentID",
                table: "Movies",
                column: "rentID",
                principalTable: "Rents",
                principalColumn: "rentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Watchlists_watchlistID",
                table: "Movies",
                column: "watchlistID",
                principalTable: "Watchlists",
                principalColumn: "watchlistID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TVshows_Buys_buyID",
                table: "TVshows",
                column: "buyID",
                principalTable: "Buys",
                principalColumn: "buyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TVshows_Rents_rentID",
                table: "TVshows",
                column: "rentID",
                principalTable: "Rents",
                principalColumn: "rentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TVshows_Watchlists_watchlistID",
                table: "TVshows",
                column: "watchlistID",
                principalTable: "Watchlists",
                principalColumn: "watchlistID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
