using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P_052_CodeFirstSqliteDb.Infrastructure.Migrations
{
    public partial class AddedPersonHeighAndBiografy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biografy",
                table: "Persons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weigh",
                table: "Persons",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biografy",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Weigh",
                table: "Persons");
        }
    }
}
