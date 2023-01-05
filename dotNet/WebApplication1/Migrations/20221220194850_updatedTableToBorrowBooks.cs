using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMokymai.Migrations
{
    /// <inheritdoc />
    public partial class updatedTableToBorrowBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_ReaderCard_ReaderCardId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_ReaderCard_Users_UserId",
                table: "ReaderCard");

            migrationBuilder.DropIndex(
                name: "IX_Books_ReaderCardId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BorrowDate",
                table: "ReaderCard");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "ReaderCard");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "ReaderCard");

            migrationBuilder.DropColumn(
                name: "ReaderCardId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "BorrowedBooksCount",
                table: "ReaderCard",
                newName: "UserBooksId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoanedBooks",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBooks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCard_UserBooksId",
                table: "ReaderCard",
                column: "UserBooksId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_BookId",
                table: "UserBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_UserId",
                table: "UserBooks",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderCard_UserBooks_UserBooksId",
                table: "ReaderCard",
                column: "UserBooksId",
                principalTable: "UserBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderCard_Users_UserId",
                table: "ReaderCard",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReaderCard_UserBooks_UserBooksId",
                table: "ReaderCard");

            migrationBuilder.DropForeignKey(
                name: "FK_ReaderCard_Users_UserId",
                table: "ReaderCard");

            migrationBuilder.DropTable(
                name: "UserBooks");

            migrationBuilder.DropIndex(
                name: "IX_ReaderCard_UserBooksId",
                table: "ReaderCard");

            migrationBuilder.DropColumn(
                name: "LoanedBooks",
                table: "ReaderCard");

            migrationBuilder.RenameColumn(
                name: "UserBooksId",
                table: "ReaderCard",
                newName: "BorrowedBooksCount");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<DateTime>(
                name: "BorrowDate",
                table: "ReaderCard",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "ReaderCard",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "ReaderCard",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ReaderCardId",
                table: "Books",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReaderCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReaderCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReaderCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReaderCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReaderCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReaderCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReaderCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReaderCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReaderCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReaderCardId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Books_ReaderCardId",
                table: "Books",
                column: "ReaderCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_ReaderCard_ReaderCardId",
                table: "Books",
                column: "ReaderCardId",
                principalTable: "ReaderCard",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderCard_Users_UserId",
                table: "ReaderCard",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
