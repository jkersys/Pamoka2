using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMokymai.Migrations
{
    /// <inheritdoc />
    public partial class fixedVirtualProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReaderCardUserBooks");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_ReaderCardId",
                table: "UserBooks",
                column: "ReaderCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBooks_ReaderCard_ReaderCardId",
                table: "UserBooks",
                column: "ReaderCardId",
                principalTable: "ReaderCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBooks_ReaderCard_ReaderCardId",
                table: "UserBooks");

            migrationBuilder.DropIndex(
                name: "IX_UserBooks_ReaderCardId",
                table: "UserBooks");

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

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCardUserBooks_UserBooksId",
                table: "ReaderCardUserBooks",
                column: "UserBooksId");
        }
    }
}
