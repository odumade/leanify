using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialDatass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("025ab58a-006a-4706-943a-5f1ca8f57426"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Instructor", "Language", "LastUpdated", "Level", "Price", "Rating", "Students", "Subtitle", "Title" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), 1, null, null, null, null, new DateTime(2025, 5, 10, 7, 4, 27, 625, DateTimeKind.Local).AddTicks(1010), null, 0f, 0m, 0, null, "C# Masterclass" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), 2, null, null, null, null, new DateTime(2025, 5, 10, 7, 4, 27, 625, DateTimeKind.Local).AddTicks(1057), null, 0f, 0m, 0, null, "Web Design" }
                });

            migrationBuilder.UpdateData(
                table: "Learnings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.UpdateData(
                table: "Learnings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.UpdateData(
                table: "Learnings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseId",
                value: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.UpdateData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.UpdateData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.UpdateData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseId",
                value: new Guid("22222222-2222-2222-2222-222222222222"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Instructor", "Language", "LastUpdated", "Level", "Price", "Rating", "Students", "Subtitle", "Title" },
                values: new object[,]
                {
                    { new Guid("025ab58a-006a-4706-943a-5f1ca8f57426"), 2, null, null, "Jane Smith", null, new DateTime(2025, 5, 10, 10, 47, 55, 630, DateTimeKind.Utc).AddTicks(733), null, 79.99f, 4.6m, 0, null, "Web Design" },
                    { new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"), 1, null, null, "John Doe", null, new DateTime(2025, 5, 10, 10, 47, 55, 630, DateTimeKind.Utc).AddTicks(712), null, 99.99f, 4.8m, 0, null, "C# Masterclass" }
                });

            migrationBuilder.UpdateData(
                table: "Learnings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"));

            migrationBuilder.UpdateData(
                table: "Learnings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"));

            migrationBuilder.UpdateData(
                table: "Learnings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseId",
                value: new Guid("025ab58a-006a-4706-943a-5f1ca8f57426"));

            migrationBuilder.UpdateData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"));

            migrationBuilder.UpdateData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"));

            migrationBuilder.UpdateData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseId",
                value: new Guid("025ab58a-006a-4706-943a-5f1ca8f57426"));
        }
    }
}
