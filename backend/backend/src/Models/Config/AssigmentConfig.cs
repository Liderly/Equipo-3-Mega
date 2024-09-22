using backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models.Config
{
    public class AssignmentConfig : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.ToTable("Assignments");
            builder.HasKey(x => x.id);
            builder.Property(x => x.status_assigment).IsRequired().HasMaxLength(100);

            builder.HasOne(x => x.Technician)
                   .WithMany(x => x.Assignments)
                   .HasForeignKey(x => x.technician_id);

            builder.HasOne(x => x.Subscriptor)
                   .WithMany(x => x.Assignments)
                   .HasForeignKey(x => x.subscriber_id);

            builder.HasOne(x => x.ServiceCatalog)
                   .WithMany(x => x.Assignments)
                   .HasForeignKey(x => x.service_id);
            builder.HasIndex(x => x.status_assigment);
            builder.HasIndex(x => x.technician_id);
            builder.HasIndex(x => x.subscriber_id);
            builder.HasIndex(x => x.service_id);
            builder.HasData(
    // Asignaciones de Telefonía
    new Assignment { id = 1, technician_id = 1, subscriber_id = 1, service_id = 1, status_assigment = "Pendiente" },
    new Assignment { id = 2, technician_id = 2, subscriber_id = 2, service_id = 2, status_assigment = "Completado" },
    new Assignment { id = 3, technician_id = 3, subscriber_id = 3, service_id = 3, status_assigment = "En Progreso" },
    new Assignment { id = 4, technician_id = 4, subscriber_id = 4, service_id = 4, status_assigment = "Pendiente" },
    // Asignaciones de Internet
    new Assignment { id = 5, technician_id = 5, subscriber_id = 5, service_id = 5, status_assigment = "Completado" },
    new Assignment { id = 6, technician_id = 6, subscriber_id = 6, service_id = 6, status_assigment = "En Progreso" },
    new Assignment { id = 7, technician_id = 7, subscriber_id = 7, service_id = 7, status_assigment = "Pendiente" },
    new Assignment { id = 8, technician_id = 8, subscriber_id = 8, service_id = 8, status_assigment = "Completado" },
    new Assignment { id = 9, technician_id = 9, subscriber_id = 9, service_id = 9, status_assigment = "En Progreso" },
    // Asignaciones de Cable
    new Assignment { id = 10, technician_id = 10, subscriber_id = 10, service_id = 10, status_assigment = "Pendiente" },
    new Assignment { id = 11, technician_id = 11, subscriber_id = 11, service_id = 11, status_assigment = "Completado" },
    new Assignment { id = 12, technician_id = 12, subscriber_id = 12, service_id = 12, status_assigment = "En Progreso" },
    new Assignment { id = 13, technician_id = 1, subscriber_id = 1, service_id = 13, status_assigment = "Pendiente" },
    new Assignment { id = 14, technician_id = 2, subscriber_id = 2, service_id = 14, status_assigment = "Completado" },
    // Asignaciones de Servicios Combinados
    new Assignment { id = 15, technician_id = 3, subscriber_id = 3, service_id = 15, status_assigment = "En Progreso" },
    new Assignment { id = 16, technician_id = 4, subscriber_id = 4, service_id = 16, status_assigment = "Pendiente" },
    new Assignment { id = 17, technician_id = 5, subscriber_id = 5, service_id = 17, status_assigment = "Completado" },
    // Asignaciones adicionales
    new Assignment { id = 18, technician_id = 6, subscriber_id = 6, service_id = 5, status_assigment = "Pendiente" },
    new Assignment { id = 19, technician_id = 7, subscriber_id = 7, service_id = 2, status_assigment = "En Progreso" },
    new Assignment { id = 20, technician_id = 8, subscriber_id = 8, service_id = 1, status_assigment = "Completado" }
);

        }
    }
}