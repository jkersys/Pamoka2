using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Country", "CreateDateTime", "ImagePath", "Name", "SpiceLevel", "Type" },
                values: new object[,]
                {
                    { 1, "Lithuanian", new DateTime(2022, 11, 24, 17, 43, 53, 727, DateTimeKind.Local).AddTicks(8851), "", "Fried Bread Sticks", "Mild", "Snacks" },
                    { 2, "Lithuanian", new DateTime(2022, 11, 24, 17, 43, 53, 727, DateTimeKind.Local).AddTicks(8900), "", "Potato dumplings", "Low", "Main dish" },
                    { 3, "Lithuanian", new DateTime(2022, 11, 24, 17, 43, 53, 727, DateTimeKind.Local).AddTicks(8904), "", "Kibinai", "Low", "Street food" }
                });

            migrationBuilder.InsertData(
                table: "RecipeItems",
                columns: new[] { "RecipeItemId", "Calories", "DishId", "Name" },
                values: new object[,]
                {
                    { 1, 150.0, 1, "Bread" },
                    { 2, 300.0, 1, "Cheese" },
                    { 3, 300.0, 1, "Mayo" },
                    { 4, 50.0, 1, "Garlic" },
                    { 5, 400.0, 2, "Potatoes" },
                    { 6, 400.0, 2, "Meat" },
                    { 7, 300.0, 2, "Sour Cream" },
                    { 8, 300.0, 3, "Dough" },
                    { 9, 200.0, 3, "Meat" },
                    { 10, 150.0, 3, "Salt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);
        }
    }
}
