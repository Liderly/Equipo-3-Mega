using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UniqueTecNum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Technicians_Quadrille_quadrille_id",
                table: "Technicians");

            migrationBuilder.DropIndex(
                name: "IX_Technicians_employee_number",
                table: "Technicians");

            migrationBuilder.AlterColumn<int>(
                name: "quadrille_id",
                table: "Technicians",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 1,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 14, 12, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 18, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 16, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 21, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 15, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 4,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 12, 26, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 5,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 8, 52, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 23, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 7,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 6, 59, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 8,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 14, 56, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 6, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 18, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 10,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 1, 59, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 11,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 21, 58, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 20, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 13,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 5, 47, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 14,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 18, 31, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 18, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 23, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 16,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 17,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 17, 16, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 12, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 19,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 1, 57, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 20,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 0, 40, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 1, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 10, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Bonus_tabs",
                columns: new[] { "Id", "bonus", "max_range", "min_range" },
                values: new object[,]
                {
                    { 4, 800, 300, 211 },
                    { 5, 1000, 400, 301 }
                });

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 1,
                column: "points",
                value: 50);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 2,
                column: "points",
                value: 40);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 3,
                column: "points",
                value: 30);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 4,
                column: "points",
                value: 20);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 5,
                column: "points",
                value: 80);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 6,
                column: "points",
                value: 30);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 7,
                column: "points",
                value: 60);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 8,
                column: "points",
                value: 40);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 9,
                column: "points",
                value: 30);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 10,
                column: "points",
                value: 50);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 11,
                column: "points",
                value: 80);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 12,
                column: "points",
                value: 40);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 13,
                column: "points",
                value: 40);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 14,
                column: "points",
                value: 30);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 15,
                column: "points",
                value: 120);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 16,
                column: "points",
                value: 70);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 17,
                column: "points",
                value: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Technicians_employee_number",
                table: "Technicians",
                column: "employee_number",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Technicians_Quadrille_quadrille_id",
                table: "Technicians",
                column: "quadrille_id",
                principalTable: "Quadrille",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Technicians_Quadrille_quadrille_id",
                table: "Technicians");

            migrationBuilder.DropIndex(
                name: "IX_Technicians_employee_number",
                table: "Technicians");

            migrationBuilder.DeleteData(
                table: "Bonus_tabs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bonus_tabs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "quadrille_id",
                table: "Technicians",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 1,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 3, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 7, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 4,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 14, 19, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 5,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 1, 36, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 4, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 7,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 21, 14, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 8,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 4, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 7, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 10,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 7, 44, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 11,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 7, 10, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 12, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 13,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 14, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 14,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 5, 43, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 20, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 16,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 22, 52, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 17,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 1, 28, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 18, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 19, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 19,
                column: "date_order",
                value: new DateTime(2024, 9, 30, 13, 55, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 20,
                column: "date_order",
                value: new DateTime(2024, 10, 1, 19, 8, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 19, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 17, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 1,
                column: "points",
                value: 5);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 2,
                column: "points",
                value: 4);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 3,
                column: "points",
                value: 3);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 4,
                column: "points",
                value: 2);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 5,
                column: "points",
                value: 8);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 6,
                column: "points",
                value: 3);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 7,
                column: "points",
                value: 6);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 8,
                column: "points",
                value: 4);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 9,
                column: "points",
                value: 3);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 10,
                column: "points",
                value: 5);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 11,
                column: "points",
                value: 8);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 12,
                column: "points",
                value: 4);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 13,
                column: "points",
                value: 4);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 14,
                column: "points",
                value: 3);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 15,
                column: "points",
                value: 12);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 16,
                column: "points",
                value: 7);

            migrationBuilder.UpdateData(
                table: "jobs_catalog",
                keyColumn: "id",
                keyValue: 17,
                column: "points",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Technicians_employee_number",
                table: "Technicians",
                column: "employee_number");

            migrationBuilder.AddForeignKey(
                name: "FK_Technicians_Quadrille_quadrille_id",
                table: "Technicians",
                column: "quadrille_id",
                principalTable: "Quadrille",
                principalColumn: "Id");
        }
    }
}
