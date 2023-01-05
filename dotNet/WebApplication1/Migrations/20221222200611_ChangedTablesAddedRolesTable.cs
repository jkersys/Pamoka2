using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiMokymai.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTablesAddedRolesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReaderCard_UserBooks_UserBooksId",
                table: "ReaderCard");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBooks_Users_UserId",
                table: "UserBooks");

            migrationBuilder.DropIndex(
                name: "IX_UserBooks_UserId",
                table: "UserBooks");

            migrationBuilder.DropIndex(
                name: "IX_ReaderCard_UserBooksId",
                table: "ReaderCard");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BooksLateToReturn",
                table: "ReaderCard");

            migrationBuilder.DropColumn(
                name: "LoanedBooks",
                table: "ReaderCard");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserBooks",
                newName: "Returned");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserBooksId",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReaderCardId",
                table: "UserBooks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BooksLateToReturnAtm",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BooksLoeanedAtm",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ReaderCardUserBooks",
                columns: table => new
                {
                    ReaderCardId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserBooksId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReaderCardUserBooks", x => new { x.ReaderCardId, x.UserBooksId });
                    table.ForeignKey(
                        name: "FK_ReaderCardUserBooks_ReaderCard_ReaderCardId",
                        column: x => x.ReaderCardId,
                        principalTable: "ReaderCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReaderCardUserBooks_UserBooks_UserBooksId",
                        column: x => x.UserBooksId,
                        principalTable: "UserBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Secretary" },
                    { 3, "Customer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserBooksId",
                table: "Users",
                column: "UserBooksId");

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCardUserBooks_UserBooksId",
                table: "ReaderCardUserBooks",
                column: "UserBooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserBooks_UserBooksId",
                table: "Users",
                column: "UserBooksId",
                principalTable: "UserBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRole_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "UserRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserBooks_UserBooksId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRole_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ReaderCardUserBooks");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserBooksId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserBooksId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReaderCardId",
                table: "UserBooks");

            migrationBuilder.DropColumn(
                name: "BooksLateToReturnAtm",
                table: "ReaderCard");

            migrationBuilder.DropColumn(
                name: "BooksLoeanedAtm",
                table: "ReaderCard");

            migrationBuilder.RenameColumn(
                name: "Returned",
                table: "UserBooks",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BooksLateToReturn",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoanedBooks",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_UserId",
                table: "UserBooks",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCard_UserBooksId",
                table: "ReaderCard",
                column: "UserBooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderCard_UserBooks_UserBooksId",
                table: "ReaderCard",
                column: "UserBooksId",
                principalTable: "UserBooks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBooks_Users_UserId",
                table: "UserBooks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
