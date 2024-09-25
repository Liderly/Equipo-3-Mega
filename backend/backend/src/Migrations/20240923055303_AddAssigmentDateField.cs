using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddAssigmentDateField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "status_assigment",
                table: "Assignments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Pendiente",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<DateTime>(
                name: "Assigment_date",
                table: "Assignments",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 1,
                column: "Assigment_date",
                value: new DateTime(2022, 2, 15, 4, 49, 32, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 2,
                column: "Assigment_date",
                value: new DateTime(2020, 6, 23, 13, 37, 51, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2020, 10, 3, 21, 29, 15, 0, DateTimeKind.Unspecified), 2, "Completado", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2022, 11, 24, 2, 48, 34, 0, DateTimeKind.Unspecified), 3, "En Progreso", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2021, 12, 19, 13, 54, 57, 0, DateTimeKind.Unspecified), 4, "Pendiente", 4, 4 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2021, 9, 9, 8, 44, 30, 0, DateTimeKind.Unspecified), 5, "Completado", 5, 5 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2023, 11, 11, 9, 10, 48, 0, DateTimeKind.Unspecified), 6, "En Progreso", 6, 6 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2021, 8, 21, 23, 49, 42, 0, DateTimeKind.Unspecified), 7, "Pendiente", 7, 7 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2022, 12, 4, 7, 35, 24, 0, DateTimeKind.Unspecified), 8, "Completado", 8, 8 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2020, 3, 21, 0, 30, 23, 0, DateTimeKind.Unspecified), 9, "En Progreso", 9, 9 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2023, 2, 25, 20, 6, 49, 0, DateTimeKind.Unspecified), 10, "Pendiente", 10, 10 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2020, 4, 18, 20, 11, 33, 0, DateTimeKind.Unspecified), 11, "Completado", 11, 11 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2023, 11, 14, 22, 23, 38, 0, DateTimeKind.Unspecified), 12, "En Progreso", 12, 12 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2021, 1, 18, 3, 37, 27, 0, DateTimeKind.Unspecified), 13, "Pendiente", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2020, 3, 14, 21, 45, 33, 0, DateTimeKind.Unspecified), 14, "Completado", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2022, 2, 1, 22, 32, 6, 0, DateTimeKind.Unspecified), 15, "En Progreso", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2020, 10, 13, 19, 33, 23, 0, DateTimeKind.Unspecified), 16, "Pendiente", 4, 4 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2022, 7, 30, 23, 35, 35, 0, DateTimeKind.Unspecified), 17, "Completado", 5, 5 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2020, 4, 3, 10, 53, 45, 0, DateTimeKind.Unspecified), 5, "Pendiente", 6, 6 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { new DateTime(2020, 2, 24, 8, 51, 34, 0, DateTimeKind.Unspecified), 2, "En Progreso", 7, 7 });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "id", "Assigment_date", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 21, new DateTime(2021, 6, 10, 10, 45, 16, 0, DateTimeKind.Unspecified), 1, "Completado", 8, 8 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DropColumn(
                name: "Assigment_date",
                table: "Assignments");

            migrationBuilder.AlterColumn<string>(
                name: "status_assigment",
                table: "Assignments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Pendiente");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 3, "En Progreso", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 4, "Pendiente", 4, 4 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 5, "Completado", 5, 5 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 6, "En Progreso", 6, 6 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 7, "Pendiente", 7, 7 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 8, "Completado", 8, 8 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 9, "En Progreso", 9, 9 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 10, "Pendiente", 10, 10 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 11, "Completado", 11, 11 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 12, "En Progreso", 12, 12 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 13, "Pendiente", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 14, "Completado", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 15, "En Progreso", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 16, "Pendiente", 4, 4 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 17, "Completado", 5, 5 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 5, "Pendiente", 6, 6 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 2, "En Progreso", 7, 7 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[] { 1, "Completado", 8, 8 });
        }
    }
}
