using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace student_grades_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentsGrades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreateAt", "FullName", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Liad Raz", "0555912051" },
                    { 2, new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Yoav Elad", "0555912281" },
                    { 3, new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Biscuit Potato", "0585917051" }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "Score", "StudentId", "Subject" },
                values: new object[,]
                {
                    { 1, 90.0, 1, "Math" },
                    { 2, 85.0, 1, "English" },
                    { 3, 78.0, 1, "History" },
                    { 4, 88.0, 2, "Math" },
                    { 5, 91.0, 2, "Science" },
                    { 6, 84.0, 2, "Literature" },
                    { 7, 76.0, 3, "Physics" },
                    { 8, 82.0, 3, "Chemistry" },
                    { 9, 89.0, 3, "Math" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
