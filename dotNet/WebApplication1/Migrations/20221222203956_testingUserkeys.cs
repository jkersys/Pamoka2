using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMokymai.Migrations
{
    /// <inheritdoc />
    public partial class testingUserkeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserBooks_UserBooksId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserBooksId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard");

            migrationBuilder.DropColumn(
                name: "UserBooksId",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard");

            migrationBuilder.AddColumn<int>(
                name: "UserBooksId",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserBooksId",
                table: "Users",
                column: "UserBooksId");

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserBooks_UserBooksId",
                table: "Users",
                column: "UserBooksId",
                principalTable: "UserBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
