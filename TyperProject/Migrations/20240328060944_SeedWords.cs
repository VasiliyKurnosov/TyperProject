using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TyperProject.Migrations
{
    public partial class SeedWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 1, "time" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 2, "year" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 3, "people" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 4, "way" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 5, "day" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 6, "man" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 7, "thing" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 8, "woman" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 9, "life" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 10, "child" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 11, "world" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 12, "school" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 13, "state" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 14, "family" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 15, "student" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 16, "group" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 17, "country" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 18, "problem" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 19, "hand" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 20, "part" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 21, "place" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 22, "case" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 23, "week" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 24, "company" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 25, "system" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 26, "program" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 27, "question" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 28, "work" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 29, "government" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "WordString" },
                values: new object[] { 30, "number" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
