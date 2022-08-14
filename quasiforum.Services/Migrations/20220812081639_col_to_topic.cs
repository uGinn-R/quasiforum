using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace quasiforum.Services.Migrations
{
    public partial class col_to_topic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Collections_CollectionId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CollectionId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionBool1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionBool2",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionBool3",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionDate1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionDate2",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionDate3",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionNumber1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionNumber2",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionNumber3",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionString1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionString2",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionString3",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionText1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionText2",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionText3",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "optionBool1",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionBool2",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionBool3",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionDate1",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionDate2",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionDate3",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionNumber1",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionNumber2",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionNumber3",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionString1",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionString2",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionString3",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionText1",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionText2",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "optionText3",
                table: "Collections");

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_TopicId",
                table: "Items",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Collections_TopicId",
                table: "Items",
                column: "TopicId",
                principalTable: "Collections",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Collections_TopicId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_TopicId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "optionBool1",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "optionBool2",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "optionBool3",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "optionDate1",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "optionDate2",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "optionDate3",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "optionNumber1",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "optionNumber2",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "optionNumber3",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "optionString1",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionString2",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionString3",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionText1",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionText2",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionText3",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionBool1",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionBool2",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionBool3",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionDate1",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionDate2",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionDate3",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionNumber1",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionNumber2",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionNumber3",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionString1",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionString2",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionString3",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionText1",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionText2",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionText3",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_CollectionId",
                table: "Items",
                column: "CollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Collections_CollectionId",
                table: "Items",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
