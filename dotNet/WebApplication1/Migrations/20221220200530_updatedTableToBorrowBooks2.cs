using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMokymai.Migrations
{
    /// <inheritdoc />
    public partial class updatedTableToBorrowBooks2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReaderCard_UserBooks_UserBooksId",
                table: "ReaderCard");

            migrationBuilder.DropForeignKey(
                name: "FK_ReaderCard_Users_UserId",
                table: "ReaderCard");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "UserBooksId",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "LoanedBooks",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Debt",
                table: "ReaderCard",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "BooksLateToReturn",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderCard_UserBooks_UserBooksId",
                table: "ReaderCard",
                column: "UserBooksId",
                principalTable: "UserBooks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderCard_Users_UserId",
                table: "ReaderCard",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
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

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserBooksId",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LoanedBooks",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Debt",
                table: "ReaderCard",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BooksLateToReturn",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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
    }
}
