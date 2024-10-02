using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTable : Migration
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
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    num_emp = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 0, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 18, 11, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 20, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 6, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 10, 29, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 23, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 4, 16, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 5, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 20, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 0, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 20, 29, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 4, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 11, 53, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 10, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 11, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 1, 39, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 3, 5, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 18, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 11, 37, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 18, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 21, 25, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 14, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 21, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 2, 38, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 8, 8, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 7, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 5, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 5, 21, 0, 0, DateTimeKind.Unspecified), "Completado" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 9, 30, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 17, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Assignments_orders",
                columns: new[] { "id", "date_order", "date_finish", "service_id", "state_order", "subscriber_id", "technician_id" },
                values: new object[,]
                {
                    { 22, new DateTime(2024, 9, 30, 18, 52, 0, 0, DateTimeKind.Unspecified), null, 3, "Pendiente", 9, 9 },
                    { 23, new DateTime(2024, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), null, 4, "En Progreso", 10, 10 },
                    { 24, new DateTime(2024, 10, 1, 0, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 22, 32, 0, 0, DateTimeKind.Unspecified), 5, "Completado", 11, 11 },
                    { 25, new DateTime(2024, 10, 1, 2, 44, 0, 0, DateTimeKind.Unspecified), null, 6, "Pendiente", 12, 12 },
                    { 26, new DateTime(2024, 9, 30, 6, 4, 0, 0, DateTimeKind.Unspecified), null, 7, "En Progreso", 1, 1 },
                    { 27, new DateTime(2024, 10, 1, 7, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 12, 52, 0, 0, DateTimeKind.Unspecified), 8, "Completado", 2, 2 },
                    { 28, new DateTime(2024, 10, 1, 13, 51, 0, 0, DateTimeKind.Unspecified), null, 9, "Pendiente", 3, 3 },
                    { 29, new DateTime(2024, 10, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), null, 10, "En Progreso", 4, 4 },
                    { 30, new DateTime(2024, 10, 1, 14, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 23, 15, 0, 0, DateTimeKind.Unspecified), 11, "Completado", 5, 5 },
                    { 31, new DateTime(2024, 10, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), null, 12, "Pendiente", 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "email", "num_emp", "password", "role" },
                values: new object[,]
                {
                    { 1, "admin@megacable.com.mx", 1, "$2a$11$Fp1/R8n7bCX5ViSJngaJ1eUsfp1YlDR1QIieylUyA3NvDendFzKMu", "Admin" },
                    { 2, "luis.gomez@megacable.com.mx", 10001, "$2a$11$N.B2HG/vGAcm1mYcI8Z9cuIEdRTbi64HxoCGB1ZdhQ2xcgDO9KmHO", "Tecnico" },
                    { 3, "laura.rodriguez@megacable.com.mx", 10002, "$2a$11$2jlORK7dYkr2u64ovSX5Vu05Y07ye28.a6139NVFLryFNVYAX6roG", "Tecnico" },
                    { 4, "carlos.perez@megacable.com.mx", 10003, "$2a$11$ECDWQkX4Qf0bO2u/BExMueosjXqyatwKcTrCuofG2N.KKOzuoqPu2", "Tecnico" },
                    { 5, "elena.ramirez@megacable.com.mx", 10004, "$2a$11$nXNA5OUm5SqR6bS3oTYh/OiaxGhioWUCoFc5uw.LGqNfIuHiAiflO", "Tecnico" },
                    { 6, "miguel.sanchez@megacable.com.mx", 10005, "$2a$11$PKUvzyNr3qFL9fj41cS3ueo7VbNB48UH5nFdC4fYiNnug3UR.o/iK", "Tecnico" },
                    { 7, "jose.torres@megacable.com.mx", 10006, "$2a$11$iWoqPnn4Olfu.yVPys9AaOgE6St3vEuW2hVPiLfmv7DRlTgL.Fwdy", "Tecnico" },
                    { 8, "adriana.diaz@megacable.com.mx", 10007, "$2a$11$u3QEAGRnBvxWcYw.2UXZ7eP44TimqtWQeZkZsVxozyrVMmKnBwpSC", "Tecnico" },
                    { 9, "fernando.gutierrez@megacable.com.mx", 10008, "$2a$11$Gs7EIl57QSooDuW6uoGBFOOrjHPGeq.nKM3f3PgLOZOCO7XKWHY7K", "Tecnico" },
                    { 10, "sofia.mendez@megacable.com.mx", 10009, "$2a$11$YsvRFMVJXNYo3YzVoK1LveD8a2WuiHDFuzfYMbpIVCPF.AMux8hgm", "Tecnico" },
                    { 11, "ricardo.ortega@megacable.com.mx", 10010, "$2a$11$HhyPvCYQGKTyD.m4T2y5r.aUzvOlGV6sU8GZz1wiNy02uqRYmLFiC", "Tecnico" },
                    { 12, "paola.martinez@megacable.com.mx", 10011, "$2a$11$ISmoLkRGZDa3zgLPE310D.ovoSQLkD/JApFW7QdyvX.gKiDuVUeKC", "Tecnico" },
                    { 13, "david.gonzalez@megacable.com.mx", 10012, "$2a$11$hauee9A3RC1eyfcUxnLMIOpcjQbA7S57j.k3yzqbTXT8U3cz1r34S", "Tecnico" },
                    { 14, "ana.vargas@megacable.com.mx", 10013, "$2a$11$oFSb5yzfXBJCE/FdT6Y/gOVHE6t/fbhjUEz7GrqzdyrhD//2I9UDq", "Tecnico" },
                    { 15, "javier.castro@megacable.com.mx", 10014, "$2a$11$xFwRhg2UVu4OH0jGO2Pf6euLLVLyXHRAHWl55bRvoKOxgqvTFXd46", "Tecnico" },
                    { 16, "mariana.flores@megacable.com.mx", 10015, "$2a$11$5l/6WpayQKyRL4VxFObtxeXB/Gl..rdzbSJP3bMGLp6TuN71WYrSG", "Tecnico" },
                    { 17, "gabriel.rojas@megacable.com.mx", 10016, "$2a$11$xrNfzM.6LgitLKQu0m8neeCVoZJjVWAUkWuvrF5895ZBrZIJDMmNq", "Tecnico" },
                    { 18, "valentina.herrera@megacable.com.mx", 10017, "$2a$11$4.EE0ssZIRRnkwSoUGEI9eKjkkIEd1788y2.p4kz25jleqxbLLUpW", "Tecnico" },
                    { 19, "alejandro.morales@megacable.com.mx", 10018, "$2a$11$Pq64MIhsApsodqoK2F0afOU88vZq/YW1c9SX8aA13OaMR3hh42slW", "Tecnico" },
                    { 20, "isabella.jimenez@megacable.com.mx", 10019, "$2a$11$M5LgKql4wJRDsqA87anC.eUcYZ6StufmuhvK93lDU5Gh3ZjMsNuIi", "Tecnico" },
                    { 21, "daniel.acosta@megacable.com.mx", 10020, "$2a$11$RiEVnqnkfJyqdsJwWJc39esCYrhjtEortz6AiErNra65fQlxx2DuO", "Tecnico" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_email",
                table: "Users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_num_emp",
                table: "Users",
                column: "num_emp",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 12, 0, 0, DateTimeKind.Unspecified), null, "Pendiente" });

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
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 26, 0, 0, DateTimeKind.Unspecified), null, "En Progreso" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 8, 52, 0, 0, DateTimeKind.Unspecified), null, "Pendiente" });

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
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 6, 59, 0, 0, DateTimeKind.Unspecified), null, "En Progreso" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 56, 0, 0, DateTimeKind.Unspecified), null, "Pendiente" });

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
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 1, 59, 0, 0, DateTimeKind.Unspecified), null, "En Progreso" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 21, 58, 0, 0, DateTimeKind.Unspecified), null, "Pendiente" });

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
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 5, 47, 0, 0, DateTimeKind.Unspecified), null, "En Progreso" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 18, 31, 0, 0, DateTimeKind.Unspecified), null, "Pendiente" });

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
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), null, "En Progreso" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 16, 0, 0, DateTimeKind.Unspecified), null, "Pendiente" });

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
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 1, 57, 0, 0, DateTimeKind.Unspecified), null, "Pendiente" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "date_order", "date_finish", "state_order" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 40, 0, 0, DateTimeKind.Unspecified), null, "En Progreso" });

            migrationBuilder.UpdateData(
                table: "Assignments_orders",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "date_order", "date_finish" },
                values: new object[] { new DateTime(2024, 10, 1, 1, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 10, 55, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
