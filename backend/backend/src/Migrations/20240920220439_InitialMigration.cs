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
                name: "Quadrille",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quadrille_number = table.Column<int>(type: "int", nullable: false),
                    region = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    branch_office = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    state_quadrille = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quadrille", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCatalog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false),
                    description_service = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCatalog", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    post_Code = table.Column<int>(type: "int", nullable: false),
                    zone_sub = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
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
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    employee_number = table.Column<int>(type: "int", nullable: false),
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
                name: "Assignments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    technician_id = table.Column<int>(type: "int", nullable: false),
                    subscriber_id = table.Column<int>(type: "int", nullable: false),
                    service_id = table.Column<int>(type: "int", nullable: false),
                    status_assigment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Assignments_ServiceCatalog_service_id",
                        column: x => x.service_id,
                        principalTable: "ServiceCatalog",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_Subscriptor_subscriber_id",
                        column: x => x.subscriber_id,
                        principalTable: "Subscriptor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_Technicians_technician_id",
                        column: x => x.technician_id,
                        principalTable: "Technicians",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Quadrille",
                columns: new[] { "Id", "branch_office", "quadrille_number", "region", "state_quadrille" },
                values: new object[,]
                {
                    { 1, "Sucursal 1", 1001, "Norte", "Estado 1" },
                    { 2, "Sucursal 2", 1002, "Sur", "Estado 2" },
                    { 3, "Sucursal 3", 1003, "Este", "Estado 3" },
                    { 4, "Sucursal 4", 1004, "Oeste", "Estado 4" },
                    { 5, "Sucursal 5", 1005, "Centro", "Estado 5" },
                    { 6, "Sucursal 6", 1006, "Noroeste", "Estado 6" },
                    { 7, "Sucursal 7", 1007, "Sureste", "Estado 7" },
                    { 8, "Sucursal 8", 1008, "Noreste", "Estado 8" },
                    { 9, "Sucursal 9", 1009, "Suroeste", "Estado 9" },
                    { 10, "Sucursal 10", 1010, "Nororiente", "Estado 10" },
                    { 11, "Sucursal 11", 1011, "Suroriente", "Estado 11" },
                    { 12, "Sucursal 12", 1012, "Noroccidente", "Estado 12" }
                });

            migrationBuilder.InsertData(
                table: "ServiceCatalog",
                columns: new[] { "id", "description_service", "duration", "points", "service_name" },
                values: new object[,]
                {
                    { 1, "Instalación y activación de línea telefónica residencial.", 2, 5, "Instalación de Línea Telefónica" },
                    { 2, "Resolución de problemas en la línea telefónica.", 1, 4, "Reparación de Línea Telefónica" },
                    { 3, "Cambio de número telefónico en la misma línea.", 1, 3, "Cambio de Número Telefónico" },
                    { 4, "Configuración de funciones en teléfono fijo.", 1, 2, "Configuración de Teléfono Fijo" },
                    { 5, "Instalación de modem y activación del servicio de internet.", 3, 8, "Instalación de Internet" },
                    { 6, "Revisión y mantenimiento preventivo del equipo de internet.", 1, 3, "Mantenimiento de Internet" },
                    { 7, "Configuración de la red Wi-Fi y dispositivos conectados.", 2, 6, "Configuración de Red Wi-Fi" },
                    { 8, "Cambio de equipo por actualización o mal funcionamiento.", 1, 4, "Cambio de Modem" },
                    { 9, "Asistencia remota o en sitio para problemas de internet.", 1, 3, "Soporte Técnico de Internet" },
                    { 10, "Instalación de decodificador y activación de canales básicos.", 2, 5, "Instalación de TV Básica" },
                    { 11, "Instalación de decodificador y activación de canales premium.", 3, 8, "Instalación de TV Premium" },
                    { 12, "Resolución de problemas con la señal de televisión.", 1, 4, "Reparación de Señal de TV" },
                    { 13, "Cambio de equipo por actualización o mal funcionamiento.", 1, 4, "Cambio de Decodificador" },
                    { 14, "Configuración y personalización de canales de TV.", 1, 3, "Configuración de Canales" },
                    { 15, "Instalación de servicio de telefonía, internet y TV.", 4, 12, "Paquete Triple Play" },
                    { 16, "Actualización de servicios combinados de telefonía, internet y TV.", 2, 7, "Actualización de Servicios" },
                    { 17, "Asistencia técnica para problemas en servicios combinados.", 2, 5, "Soporte Integral de Servicios" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptor",
                columns: new[] { "id", "last_name", "name", "post_Code", "street", "zone_sub" },
                values: new object[,]
                {
                    { 1, "Garcia", "Juan", 12345, "Calle 1", "Zona Norte" },
                    { 2, "Hernandez", "Maria", 12346, "Calle 2", "Zona Sur" },
                    { 3, "Lopez", "Pedro", 12347, "Calle 3", "Zona Este" },
                    { 4, "Martinez", "Ana", 12348, "Calle 4", "Zona Oeste" },
                    { 5, "Gomez", "Luis", 12349, "Calle 5", "Zona Centro" },
                    { 6, "Rodriguez", "Laura", 12350, "Calle 6", "Zona Norte" },
                    { 7, "Perez", "Carlos", 12351, "Calle 7", "Zona Sur" },
                    { 8, "Ramirez", "Elena", 12352, "Calle 8", "Zona Este" },
                    { 9, "Sanchez", "Miguel", 12353, "Calle 9", "Zona Oeste" },
                    { 10, "Torres", "Jose", 12354, "Calle 10", "Zona Centro" },
                    { 11, "Diaz", "Adriana", 12355, "Calle 11", "Zona Norte" },
                    { 12, "Gutierrez", "Fernando", 12356, "Calle 12", "Zona Sur" }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "id", "employee_number", "last_name", "name", "quadrille_id" },
                values: new object[,]
                {
                    { 1, 10001, "Gomez", "Luis", 1 },
                    { 2, 10002, "Rodriguez", "Laura", 2 },
                    { 3, 10003, "Perez", "Carlos", 3 },
                    { 4, 10004, "Ramirez", "Elena", 4 },
                    { 5, 10005, "Sanchez", "Miguel", 5 },
                    { 6, 10006, "Torres", "Jose", 6 },
                    { 7, 10007, "Diaz", "Adriana", 7 },
                    { 8, 10008, "Gutierrez", "Fernando", 8 },
                    { 9, 10009, "Mendez", "Sofia", 9 },
                    { 10, 10010, "Ortega", "Ricardo", 10 },
                    { 11, 10011, "Martinez", "Paola", 11 },
                    { 12, 10012, "Gonzalez", "David", 12 }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "id", "service_id", "status_assigment", "subscriber_id", "technician_id" },
                values: new object[,]
                {
                    { 1, 1, "Pendiente", 1, 1 },
                    { 2, 2, "Completado", 2, 2 },
                    { 3, 3, "En Progreso", 3, 3 },
                    { 4, 4, "Pendiente", 4, 4 },
                    { 5, 5, "Completado", 5, 5 },
                    { 6, 6, "En Progreso", 6, 6 },
                    { 7, 7, "Pendiente", 7, 7 },
                    { 8, 8, "Completado", 8, 8 },
                    { 9, 9, "En Progreso", 9, 9 },
                    { 10, 10, "Pendiente", 10, 10 },
                    { 11, 11, "Completado", 11, 11 },
                    { 12, 12, "En Progreso", 12, 12 },
                    { 13, 13, "Pendiente", 1, 1 },
                    { 14, 14, "Completado", 2, 2 },
                    { 15, 15, "En Progreso", 3, 3 },
                    { 16, 16, "Pendiente", 4, 4 },
                    { 17, 17, "Completado", 5, 5 },
                    { 18, 5, "Pendiente", 6, 6 },
                    { 19, 2, "En Progreso", 7, 7 },
                    { 20, 1, "Completado", 8, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_service_id",
                table: "Assignments",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_subscriber_id",
                table: "Assignments",
                column: "subscriber_id");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_technician_id",
                table: "Assignments",
                column: "technician_id");

            migrationBuilder.CreateIndex(
                name: "IX_Technicians_quadrille_id",
                table: "Technicians",
                column: "quadrille_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "ServiceCatalog");

            migrationBuilder.DropTable(
                name: "Subscriptor");

            migrationBuilder.DropTable(
                name: "Technicians");

            migrationBuilder.DropTable(
                name: "Quadrille");
        }
    }
}
