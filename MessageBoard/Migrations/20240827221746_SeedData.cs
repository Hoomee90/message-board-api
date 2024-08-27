using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoard.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Content", "PostedOn", "Username" },
                values: new object[,]
                {
                    { 1, "Woolly Mammoth", new DateTime(2018, 8, 18, 7, 22, 16, 0, DateTimeKind.Unspecified), "Matilda" },
                    { 2, "Dinosaur", new DateTime(2018, 8, 18, 0, 22, 16, 0, DateTimeKind.Local), "Rexie" },
                    { 3, "Dinosaur", new DateTime(2018, 8, 18, 0, 22, 16, 0, DateTimeKind.Local), "Matilda" },
                    { 4, "Shark", new DateTime(2022, 8, 28, 11, 22, 16, 0, DateTimeKind.Unspecified), "Pip" },
                    { 5, "Dinosaur", new DateTime(2010, 12, 1, 1, 23, 50, 0, DateTimeKind.Unspecified), "Bartholomew" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5);
        }
    }
}
