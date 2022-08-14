using Microsoft.EntityFrameworkCore.Migrations;

namespace quasiforum.Services.Migrations
{
    public partial class renaming_topic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectionAuthorID",
                table: "Topics");

            migrationBuilder.AddColumn<string>(
                name: "TopicAuthorID",
                table: "Topics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopicAuthorID",
                table: "Topics");

            migrationBuilder.AddColumn<string>(
                name: "CollectionAuthorID",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
