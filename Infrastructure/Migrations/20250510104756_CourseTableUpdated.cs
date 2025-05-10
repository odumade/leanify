using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CourseTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Price = table.Column<float>(type: "REAL", nullable: false),
                    Instructor = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(18,1)", nullable: false),
                    Image = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Subtitle = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Students = table.Column<int>(type: "INTEGER", nullable: false),
                    Language = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Level = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requirements_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Learnings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RequirementId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Learnings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Learnings_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Learnings_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Programming" },
                    { 2, "Design" },
                    { 3, "Business" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Instructor", "Language", "LastUpdated", "Level", "Price", "Rating", "Students", "Subtitle", "Title" },
                values: new object[,]
                {
                    { new Guid("025ab58a-006a-4706-943a-5f1ca8f57426"), 2, null, null, "Jane Smith", null, new DateTime(2025, 5, 10, 10, 47, 55, 630, DateTimeKind.Utc).AddTicks(733), null, 79.99f, 4.6m, 0, null, "Web Design" },
                    { new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"), 1, null, null, "John Doe", null, new DateTime(2025, 5, 10, 10, 47, 55, 630, DateTimeKind.Utc).AddTicks(712), null, 99.99f, 4.8m, 0, null, "C# Masterclass" }
                });

            migrationBuilder.InsertData(
                table: "Learnings",
                columns: new[] { "Id", "CourseId", "Name", "RequirementId" },
                values: new object[,]
                {
                    { 1, new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"), "OOP Principles", null },
                    { 2, new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"), "ASP.NET Core", null },
                    { 3, new Guid("025ab58a-006a-4706-943a-5f1ca8f57426"), "Responsive Design", null }
                });

            migrationBuilder.InsertData(
                table: "Requirements",
                columns: new[] { "Id", "CourseId", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"), "Basic programming" },
                    { 2, new Guid("b5dee3c1-d269-4a20-aef0-df83e60332ed"), "Visual Studio" },
                    { 3, new Guid("025ab58a-006a-4706-943a-5f1ca8f57426"), "Creative mindset" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Learnings_CourseId",
                table: "Learnings",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Learnings_RequirementId",
                table: "Learnings",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_Requirements_CourseId",
                table: "Requirements",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Learnings");

            migrationBuilder.DropTable(
                name: "Requirements");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
