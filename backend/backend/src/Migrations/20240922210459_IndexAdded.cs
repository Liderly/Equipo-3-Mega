using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class IndexAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Technicians_employee_number",
                table: "Technicians",
                column: "employee_number");

            migrationBuilder.CreateIndex(
                name: "IX_Technicians_last_name_name",
                table: "Technicians",
                columns: new[] { "last_name", "name" });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptor_last_name_name",
                table: "Subscriptor",
                columns: new[] { "last_name", "name" });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptor_post_Code",
                table: "Subscriptor",
                column: "post_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptor_zone_sub",
                table: "Subscriptor",
                column: "zone_sub");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCatalog_points",
                table: "ServiceCatalog",
                column: "points");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCatalog_service_name",
                table: "ServiceCatalog",
                column: "service_name");

            migrationBuilder.CreateIndex(
                name: "IX_Quadrille_quadrille_number",
                table: "Quadrille",
                column: "quadrille_number");

            migrationBuilder.CreateIndex(
                name: "IX_Quadrille_region",
                table: "Quadrille",
                column: "region");

            migrationBuilder.CreateIndex(
                name: "IX_Quadrille_state_quadrille",
                table: "Quadrille",
                column: "state_quadrille");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_status_assigment",
                table: "Assignments",
                column: "status_assigment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Technicians_employee_number",
                table: "Technicians");

            migrationBuilder.DropIndex(
                name: "IX_Technicians_last_name_name",
                table: "Technicians");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptor_last_name_name",
                table: "Subscriptor");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptor_post_Code",
                table: "Subscriptor");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptor_zone_sub",
                table: "Subscriptor");

            migrationBuilder.DropIndex(
                name: "IX_ServiceCatalog_points",
                table: "ServiceCatalog");

            migrationBuilder.DropIndex(
                name: "IX_ServiceCatalog_service_name",
                table: "ServiceCatalog");

            migrationBuilder.DropIndex(
                name: "IX_Quadrille_quadrille_number",
                table: "Quadrille");

            migrationBuilder.DropIndex(
                name: "IX_Quadrille_region",
                table: "Quadrille");

            migrationBuilder.DropIndex(
                name: "IX_Quadrille_state_quadrille",
                table: "Quadrille");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_status_assigment",
                table: "Assignments");
        }
    }
}
