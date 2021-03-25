using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Videostore.Data.Migrations
{
    public partial class nameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "birthday",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "nationality",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "nationality",
                table: "Actors");

            migrationBuilder.AddColumn<DateTime>(
                name: "directorBirthday",
                table: "Directors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "directorName",
                table: "Directors",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "directorNationality",
                table: "Directors",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "actorBirthday",
                table: "Actors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "actorName",
                table: "Actors",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "actorNationality",
                table: "Actors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "directorBirthday",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "directorName",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "directorNationality",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "actorBirthday",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "actorName",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "actorNationality",
                table: "Actors");

            migrationBuilder.AddColumn<DateTime>(
                name: "birthday",
                table: "Directors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Directors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationality",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "birthday",
                table: "Actors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Actors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationality",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
