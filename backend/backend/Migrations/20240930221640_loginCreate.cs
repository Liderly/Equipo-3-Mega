using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class loginCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 1,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 16, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 18, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 4, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 7, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 4,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 23, 39, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 5,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 20, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 7,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 21, 26, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 8,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 20, 40, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 10,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 5, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 11,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 2, 33, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 23, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 13,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 2, 44, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 14,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 17, 22, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 10, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 10, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 16,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 1, 48, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 17,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 0, 52, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 2, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 0, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 19,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 20,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 3, 21, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 22, 14, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 1,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 9, 33, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 21, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 1, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 4,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 20, 35, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 5,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 10, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 13, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 7,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 7, 33, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 8,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 1, 46, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 8, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 5, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 10,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 18, 24, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 11,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 11, 4, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 14, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 13,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 4, 23, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 14,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 23, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 7, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 16,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 14, 17, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 17,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 0, 47, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 1, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 22, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 19,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 3, 11, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 20,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 20, 57, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 11, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 16, 26, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
