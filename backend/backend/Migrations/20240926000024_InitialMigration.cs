using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bonus_tabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    min_range = table.Column<int>(type: "int", nullable: false),
                    max_range = table.Column<int>(type: "int", nullable: false),
                    bonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonus_tabs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jobs_catalog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs_catalog", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Quadrille",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quadrille_number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quadrille", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    street_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_code = table.Column<int>(type: "int", nullable: false),
                    zone = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    phone = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_number = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    phone = table.Column<long>(type: "bigint", nullable: false),
                    quadrille_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.id);
                    table.ForeignKey(
                        name: "FK_Technicians_Quadrille_quadrille_id",
                        column: x => x.quadrille_id,
                        principalTable: "Quadrille",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Assignments_orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_order = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    date_finish = table.Column<DateTime>(type: "datetime", nullable: true),
                    technician_id = table.Column<int>(type: "int", nullable: false),
                    subscriber_id = table.Column<int>(type: "int", nullable: false),
                    service_id = table.Column<int>(type: "int", nullable: false),
                    state_order = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "Pendiente")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments_orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_Assignments_orders_Subscriptor_subscriber_id",
                        column: x => x.subscriber_id,
                        principalTable: "Subscriptor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_orders_Technicians_technician_id",
                        column: x => x.technician_id,
                        principalTable: "Technicians",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_orders_jobs_catalog_service_id",
                        column: x => x.service_id,
                        principalTable: "jobs_catalog",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bonus_tabs",
                columns: new[] { "Id", "bonus", "max_range", "min_range" },
                values: new object[,]
                {
                    { 1, 0, 80, 0 },
                    { 2, 300, 150, 81 },
                    { 3, 500, 210, 151 }
                });

            migrationBuilder.InsertData(
                table: "Quadrille",
                columns: new[] { "Id", "quadrille_number" },
                values: new object[,]
                {
                    { 1, 1001 },
                    { 2, 1002 },
                    { 3, 1003 },
                    { 4, 1004 },
                    { 5, 1005 },
                    { 6, 1006 },
                    { 7, 1007 },
                    { 8, 1008 },
                    { 9, 1009 },
                    { 10, 1010 }
                });

            migrationBuilder.InsertData(
                table: "Subscriptor",
                columns: new[] { "id", "last_name", "name", "number", "phone", "post_code", "street", "street_number", "zone" },
                values: new object[,]
                {
                    { 1, "Garcia", "Juan", 1, 3919890119L, 12345, "Calle 1", "1219", "Zona Norte" },
                    { 2, "Hernandez", "Maria", 2, 3919890120L, 12346, "Calle 2", "2468", "Zona Sur" },
                    { 3, "Lopez", "Pedro", 3, 3919890121L, 12347, "Calle 3", "3579", "Zona Este" },
                    { 4, "Martinez", "Ana", 4, 3919890122L, 12348, "Calle 4", "4680", "Zona Oeste" },
                    { 5, "Gomez", "Luis", 5, 3919890123L, 12349, "Calle 5", "5791", "Zona Centro" },
                    { 6, "Rodriguez", "Laura", 6, 3919890124L, 12350, "Calle 6", "6802", "Zona Norte" },
                    { 7, "Perez", "Carlos", 7, 3919890125L, 12351, "Calle 7", "7913", "Zona Sur" },
                    { 8, "Ramirez", "Elena", 8, 3919890126L, 12352, "Calle 8", "8024", "Zona Este" },
                    { 9, "Sanchez", "Miguel", 9, 3919890127L, 12353, "Calle 9", "9135", "Zona Oeste" },
                    { 10, "Torres", "Jose", 10, 3919890128L, 12354, "Calle 10", "1046", "Zona Centro" },
                    { 11, "Diaz", "Adriana", 11, 3919890129L, 12355, "Calle 11", "1157", "Zona Norte" },
                    { 12, "Gutierrez", "Fernando", 12, 3919890130L, 12356, "Calle 12", "1268", "Zona Sur" },
                    { 13, "Vazquez", "Sofia", 13, 3919890131L, 12357, "Avenida Principal", "2435", "Zona Noreste" },
                    { 14, "Fernandez", "Roberto", 14, 3919890132L, 12358, "Boulevard Central", "789", "Zona Sureste" },
                    { 15, "Ortega", "Carmen", 15, 3919890133L, 12359, "Paseo de la Reforma", "5012", "Zona Noroeste" },
                    { 16, "Morales", "Javier", 16, 3919890134L, 12360, "Calzada de los Heroes", "1670", "Zona Suroeste" },
                    { 17, "Castillo", "Gabriela", 17, 3919890135L, 12361, "Circuito Interior", "3845", "Zona Metropolitana" },
                    { 18, "Ruiz", "Alejandro", 18, 3919890136L, 12362, "Avenida Insurgentes", "9276", "Zona Histórica" },
                    { 19, "Mendoza", "Patricia", 19, 3919890137L, 12363, "Calle del Bosque", "4523", "Zona Residencial" },
                    { 20, "Vargas", "Ricardo", 20, 3919890138L, 12364, "Avenida de las Flores", "6789", "Zona Comercial" }
                });

            migrationBuilder.InsertData(
                table: "jobs_catalog",
                columns: new[] { "id", "description", "duration", "name", "points" },
                values: new object[,]
                {
                    { 1, "Instalación y activación de línea telefónica residencial.", 2, "Instalación de Línea Telefónica", 5 },
                    { 2, "Resolución de problemas en la línea telefónica.", 1, "Reparación de Línea Telefónica", 4 },
                    { 3, "Cambio de número telefónico en la misma línea.", 1, "Cambio de Número Telefónico", 3 },
                    { 4, "Configuración de funciones en teléfono fijo.", 1, "Configuración de Teléfono Fijo", 2 },
                    { 5, "Instalación de modem y activación del servicio de internet.", 3, "Instalación de Internet", 8 },
                    { 6, "Revisión y mantenimiento preventivo del equipo de internet.", 1, "Mantenimiento de Internet", 3 },
                    { 7, "Configuración de la red Wi-Fi y dispositivos conectados.", 2, "Configuración de Red Wi-Fi", 6 },
                    { 8, "Cambio de equipo por actualización o mal funcionamiento.", 1, "Cambio de Modem", 4 },
                    { 9, "Asistencia remota o en sitio para problemas de internet.", 1, "Soporte Técnico de Internet", 3 },
                    { 10, "Instalación de decodificador y activación de canales básicos.", 2, "Instalación de TV Básica", 5 },
                    { 11, "Instalación de decodificador y activación de canales premium.", 3, "Instalación de TV Premium", 8 },
                    { 12, "Resolución de problemas con la señal de televisión.", 1, "Reparación de Señal de TV", 4 },
                    { 13, "Cambio de equipo por actualización o mal funcionamiento.", 1, "Cambio de Decodificador", 4 },
                    { 14, "Configuración y personalización de canales de TV.", 1, "Configuración de Canales", 3 },
                    { 15, "Instalación de servicio de telefonía, internet y TV.", 4, "Paquete Triple Play", 12 },
                    { 16, "Actualización de servicios combinados de telefonía, internet y TV.", 2, "Actualización de Servicios", 7 },
                    { 17, "Asistencia técnica para problemas en servicios combinados.", 2, "Soporte Integral de Servicios", 5 }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "id", "employee_number", "last_name", "name", "phone", "quadrille_id" },
                values: new object[,]
                {
                    { 1, 10001, "Gomez", "Luis", 3310194098L, 1 },
                    { 2, 10002, "Rodriguez", "Laura", 3310194099L, 1 },
                    { 3, 10003, "Perez", "Carlos", 3310194100L, 2 },
                    { 4, 10004, "Ramirez", "Elena", 3310194101L, 2 },
                    { 5, 10005, "Sanchez", "Miguel", 3310194102L, 3 },
                    { 6, 10006, "Torres", "Jose", 3310194103L, 3 },
                    { 7, 10007, "Diaz", "Adriana", 3310194104L, 4 },
                    { 8, 10008, "Gutierrez", "Fernando", 3310194105L, 4 },
                    { 9, 10009, "Mendez", "Sofia", 3310194106L, 5 },
                    { 10, 10010, "Ortega", "Ricardo", 3310194107L, 5 },
                    { 11, 10011, "Martinez", "Paola", 3310194108L, 6 },
                    { 12, 10012, "Gonzalez", "David", 3310194109L, 6 },
                    { 13, 10013, "Vargas", "Ana", 3310194110L, 7 },
                    { 14, 10014, "Castro", "Javier", 3310194111L, 7 },
                    { 15, 10015, "Flores", "Mariana", 3310194112L, 8 },
                    { 16, 10016, "Rojas", "Gabriel", 3310194113L, 8 },
                    { 17, 10017, "Herrera", "Valentina", 3310194114L, 9 },
                    { 18, 10018, "Morales", "Alejandro", 3310194115L, 9 },
                    { 19, 10019, "Jimenez", "Isabella", 3310194116L, 10 },
                    { 20, 10020, "Acosta", "Daniel", 3310194117L, 10 }
                });

            migrationBuilder.InsertData(
                table: "Assignments_orders",
                columns: new[] { "id", "date_order", "date_finish", "service_id", "state_order", "subscriber_id", "technician_id" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), null, 1, "Pendiente", 1, 1 },
                    { 2, new DateTime(2024, 9, 30, 12, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 3, 55, 0, 0, DateTimeKind.Unspecified), 2, "Completado", 2, 2 },
                    { 3, new DateTime(2024, 10, 1, 0, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 7, 15, 0, 0, DateTimeKind.Unspecified), 2, "Completado", 2, 2 },
                    { 4, new DateTime(2024, 10, 1, 14, 19, 0, 0, DateTimeKind.Unspecified), null, 3, "En Progreso", 3, 3 },
                    { 5, new DateTime(2024, 10, 1, 1, 36, 0, 0, DateTimeKind.Unspecified), null, 4, "Pendiente", 4, 4 },
                    { 6, new DateTime(2024, 10, 1, 4, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 5, "Completado", 5, 5 },
                    { 7, new DateTime(2024, 9, 30, 21, 14, 0, 0, DateTimeKind.Unspecified), null, 6, "En Progreso", 6, 6 },
                    { 8, new DateTime(2024, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified), null, 7, "Pendiente", 7, 7 },
                    { 9, new DateTime(2024, 9, 30, 4, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 7, 4, 0, 0, DateTimeKind.Unspecified), 8, "Completado", 8, 8 },
                    { 10, new DateTime(2024, 9, 30, 7, 44, 0, 0, DateTimeKind.Unspecified), null, 9, "En Progreso", 9, 9 },
                    { 11, new DateTime(2024, 10, 1, 7, 10, 0, 0, DateTimeKind.Unspecified), null, 10, "Pendiente", 10, 10 },
                    { 12, new DateTime(2024, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 12, 16, 0, 0, DateTimeKind.Unspecified), 11, "Completado", 11, 11 },
                    { 13, new DateTime(2024, 9, 30, 14, 20, 0, 0, DateTimeKind.Unspecified), null, 12, "En Progreso", 12, 12 },
                    { 14, new DateTime(2024, 10, 1, 5, 43, 0, 0, DateTimeKind.Unspecified), null, 13, "Pendiente", 1, 1 },
                    { 15, new DateTime(2024, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 20, 20, 0, 0, DateTimeKind.Unspecified), 14, "Completado", 2, 2 },
                    { 16, new DateTime(2024, 9, 30, 22, 52, 0, 0, DateTimeKind.Unspecified), null, 15, "En Progreso", 3, 3 },
                    { 17, new DateTime(2024, 10, 1, 1, 28, 0, 0, DateTimeKind.Unspecified), null, 16, "Pendiente", 4, 4 },
                    { 18, new DateTime(2024, 10, 1, 18, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 19, 44, 0, 0, DateTimeKind.Unspecified), 17, "Completado", 5, 5 },
                    { 19, new DateTime(2024, 9, 30, 13, 55, 0, 0, DateTimeKind.Unspecified), null, 5, "Pendiente", 6, 6 },
                    { 20, new DateTime(2024, 10, 1, 19, 8, 0, 0, DateTimeKind.Unspecified), null, 2, "En Progreso", 7, 7 },
                    { 21, new DateTime(2024, 10, 1, 19, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 17, 44, 0, 0, DateTimeKind.Unspecified), 1, "Completado", 8, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_orders_service_id",
                table: "Assignments_orders",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_orders_state_order",
                table: "Assignments_orders",
                column: "state_order");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_orders_subscriber_id",
                table: "Assignments_orders",
                column: "subscriber_id");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_orders_technician_id",
                table: "Assignments_orders",
                column: "technician_id");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_catalog_name",
                table: "jobs_catalog",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_catalog_points",
                table: "jobs_catalog",
                column: "points");

            migrationBuilder.CreateIndex(
                name: "IX_Quadrille_quadrille_number",
                table: "Quadrille",
                column: "quadrille_number");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptor_last_name_name",
                table: "Subscriptor",
                columns: new[] { "last_name", "name" });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptor_post_code",
                table: "Subscriptor",
                column: "post_code");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptor_zone",
                table: "Subscriptor",
                column: "zone");

            migrationBuilder.CreateIndex(
                name: "IX_Technicians_employee_number",
                table: "Technicians",
                column: "employee_number");

            migrationBuilder.CreateIndex(
                name: "IX_Technicians_last_name_name",
                table: "Technicians",
                columns: new[] { "last_name", "name" });

            migrationBuilder.CreateIndex(
                name: "IX_Technicians_quadrille_id",
                table: "Technicians",
                column: "quadrille_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments_orders");

            migrationBuilder.DropTable(
                name: "Bonus_tabs");

            migrationBuilder.DropTable(
                name: "Subscriptor");

            migrationBuilder.DropTable(
                name: "Technicians");

            migrationBuilder.DropTable(
                name: "jobs_catalog");

            migrationBuilder.DropTable(
                name: "Quadrille");
        }
    }
}
