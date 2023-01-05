using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMokymai.Migrations
{
    /// <inheritdoc />
    public partial class EditedRelationshipBetweenReaderCardAndUserBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserBooksId",
                table: "ReaderCard");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserBooksId",
                table: "ReaderCard",
                type: "INTEGER",
                nullable: true);
        }
    }
}
