using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMokymai.Migrations
{
    /// <inheritdoc />
    public partial class AddedCardReaderTabble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReaderCardId",
                table: "Books",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReaderCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    BorrowedBooksCount = table.Column<int>(type: "INTEGER", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BooksLateToReturn = table.Column<int>(type: "INTEGER", nullable: false),
                    Debt = table.Column<double>(type: "REAL", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReaderCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReaderCard_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_ReaderCard_ReaderCardId",
                table: "Books",
                column: "ReaderCardId",
                principalTable: "ReaderCard",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_ReaderCard_ReaderCardId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "ReaderCard");

            migrationBuilder.DropIndex(
                name: "IX_Books_ReaderCardId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ReaderCardId",
                table: "Books");
        }
    }
}
