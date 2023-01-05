using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMokymai.Migrations
{
    /// <inheritdoc />
    public partial class AddedReaderCardKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard");

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard");

            migrationBuilder.CreateIndex(
                name: "IX_ReaderCard_UserId",
                table: "ReaderCard",
                column: "UserId");
        }
    }
}
