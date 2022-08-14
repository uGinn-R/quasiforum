using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace quasiforum.Services.Migrations
{
    public partial class added_regdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "collectionType",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "LastLoggedIn",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "Registered",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Registered",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "collectionType",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoggedIn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);
        }
    }
}
