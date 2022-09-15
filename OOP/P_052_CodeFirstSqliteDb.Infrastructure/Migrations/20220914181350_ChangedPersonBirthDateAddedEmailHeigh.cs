using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P_052_CodeFirstSqliteDb.Infrastructure.Migrations
{
    public partial class ChangedPersonBirthDateAddedEmailHeigh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Persons",
                newName: "Email");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Persons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Heigh",
                table: "Persons",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Heigh",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Persons",
                newName: "Age");
        }
    }
}
