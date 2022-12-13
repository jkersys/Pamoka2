using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiMokymai.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationAddedDataAndFixedTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes");

            migrationBuilder.RenameTable(
                name: "Dishes",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverType", "PublishYear", "Title" },
                values: new object[,]
                {
                    { 1, "Tolkin", 0, 1991, "Hobbit" },
                    { 2, "Leo Tolstoy", 0, 1992, "War and peace" },
                    { 3, "William Shakespeare", 1, 1993, "Hamlet" },
                    { 4, "Homer", 2, 1994, "The Odyssey" },
                    { 5, "Fyodor Dostoyevsky", 0, 1995, " Crime and Punishment" },
                    { 6, "Tolkin", 0, 1991, "Hobbit" },
                    { 7, "Leo Tolstoy", 0, 1992, "War and peace" },
                    { 8, "Joseph Conrad", 1, 1998, " Heart of Darkness" },
                    { 9, "Great Expectations", 2, 1999, "Great Expectations" },
                    { 10, "Tolkin", 0, 1991, "Hobbit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Dishes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes",
                column: "Id");
        }
    }
}
