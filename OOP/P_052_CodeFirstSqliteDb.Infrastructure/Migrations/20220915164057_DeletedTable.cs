using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P_052_CodeFirstSqliteDb.Infrastructure.Migrations
{
    public partial class DeletedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Test",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
