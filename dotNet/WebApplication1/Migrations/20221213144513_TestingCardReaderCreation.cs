using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMokymai.Migrations
{
    /// <inheritdoc />
    public partial class TestingCardReaderCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReaderCard_Users_UserId",
                table: "ReaderCard");

            migrationBuilder.DropIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard",
                column: "UserId",
                unique: true);

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
                name: "FK_ReaderCard_Users_UserId",
                table: "ReaderCard");

            migrationBuilder.DropIndex(
                name: "IX_ReaderCard_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard",
                column: "UserId");

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
