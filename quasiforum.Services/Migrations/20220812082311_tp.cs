using Microsoft.EntityFrameworkCore.Migrations;

namespace quasiforum.Services.Migrations
{
    public partial class tp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_AspNetUsers_AppUserId",
                table: "Collections");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Items_CommentedItemid",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Collections_TopicId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Collections",
                table: "Collections");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Collections",
                newName: "Topics");

            migrationBuilder.RenameIndex(
                name: "IX_Items_TopicId",
                table: "Posts",
                newName: "IX_Posts_TopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Collections_AppUserId",
                table: "Topics",
                newName: "IX_Topics_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topics",
                table: "Topics",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_CommentedItemid",
                table: "Comments",
                column: "CommentedItemid",
                principalTable: "Posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_AspNetUsers_AppUserId",
                table: "Topics",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_CommentedItemid",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_AspNetUsers_AppUserId",
                table: "Topics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topics",
                table: "Topics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Topics",
                newName: "Collections");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Topics_AppUserId",
                table: "Collections",
                newName: "IX_Collections_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_TopicId",
                table: "Items",
                newName: "IX_Items_TopicId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Collections",
                table: "Collections",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_AspNetUsers_AppUserId",
                table: "Collections",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Items_CommentedItemid",
                table: "Comments",
                column: "CommentedItemid",
                principalTable: "Items",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Collections_TopicId",
                table: "Items",
                column: "TopicId",
                principalTable: "Collections",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
