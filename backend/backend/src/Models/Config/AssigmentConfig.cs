using backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models.Config
{
    public class AssignmentConfig : IEntityTypeConfiguration<Assignment>
    {
        Random random = new Random();

        DateTime RandomDate()
        {
            int year = random.Next(2020, 2024); // Genera un año entre 2020 y 2023
            int month = random.Next(1, 13); // Genera un mes entre 1 y 12
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1); // Genera un día válido para el mes y año
            int hour = random.Next(0, 24); // Genera una hora entre 0 y 23
            int minute = random.Next(0, 60); // Genera un minuto entre 0 y 59
            int second = random.Next(0, 60); // Genera un segundo entre 0 y 59

            return new DateTime(year, month, day, hour, minute, second);
        }
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.ToTable("Assignments");
            builder.HasKey(x => x.id);
            builder.Property(x => x.status_assigment).IsRequired().HasMaxLength(100).HasDefaultValue("Pendiente");
            builder.Property(x => x.Assigment_date).IsRequired().HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
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
    new Assignment { id = 1, technician_id = 1, subscriber_id = 1, service_id = 1, status_assigment = "Pendiente",Assigment_date=RandomDate() },
    new Assignment { id = 2, technician_id = 2, subscriber_id = 2, service_id = 2, status_assigment = "Completado", Assigment_date = RandomDate() },
    new Assignment { id = 3, technician_id = 2, subscriber_id = 2, service_id = 2, status_assigment = "Completado", Assigment_date = RandomDate() },
    new Assignment { id = 4, technician_id = 3, subscriber_id = 3, service_id = 3, status_assigment = "En Progreso", Assigment_date = RandomDate()},
    new Assignment { id = 5, technician_id = 4, subscriber_id = 4, service_id = 4, status_assigment = "Pendiente", Assigment_date = RandomDate() },
    // Asignaciones de Internet
    new Assignment { id = 6, technician_id = 5, subscriber_id = 5, service_id = 5, status_assigment = "Completado", Assigment_date = RandomDate() },
    new Assignment { id = 7, technician_id = 6, subscriber_id = 6, service_id = 6, status_assigment = "En Progreso" , Assigment_date = RandomDate() },
    new Assignment { id = 8, technician_id = 7, subscriber_id = 7, service_id = 7, status_assigment = "Pendiente" , Assigment_date = RandomDate() },
    new Assignment { id = 9, technician_id = 8, subscriber_id = 8, service_id = 8, status_assigment = "Completado" , Assigment_date = RandomDate() },
    new Assignment { id = 10, technician_id = 9, subscriber_id = 9, service_id = 9, status_assigment = "En Progreso" , Assigment_date = RandomDate() },
    // Asignaciones de Cable
    new Assignment { id = 11, technician_id = 10, subscriber_id = 10, service_id = 10, status_assigment = "Pendiente" , Assigment_date = RandomDate() },
    new Assignment { id = 12, technician_id = 11, subscriber_id = 11, service_id = 11, status_assigment = "Completado" , Assigment_date = RandomDate() },
    new Assignment { id = 13, technician_id = 12, subscriber_id = 12, service_id = 12, status_assigment = "En Progreso" , Assigment_date = RandomDate() },
    new Assignment { id = 14, technician_id = 1, subscriber_id = 1, service_id = 13, status_assigment = "Pendiente" , Assigment_date = RandomDate() },
    new Assignment { id = 15, technician_id = 2, subscriber_id = 2, service_id = 14, status_assigment = "Completado" , Assigment_date = RandomDate() },
    // Asignaciones de Servicios Combinados
    new Assignment { id = 16, technician_id = 3, subscriber_id = 3, service_id = 15, status_assigment = "En Progreso"   , Assigment_date = RandomDate() },
    new Assignment { id = 17, technician_id = 4, subscriber_id = 4, service_id = 16, status_assigment = "Pendiente" , Assigment_date = RandomDate() },
    new Assignment { id = 18, technician_id = 5, subscriber_id = 5, service_id = 17, status_assigment = "Completado" , Assigment_date = RandomDate() },
    // Asignaciones adicionales
    new Assignment { id = 19, technician_id = 6, subscriber_id = 6, service_id = 5, status_assigment = "Pendiente" , Assigment_date = RandomDate() },
    new Assignment { id = 20, technician_id = 7, subscriber_id = 7, service_id = 2, status_assigment = "En Progreso" , Assigment_date = RandomDate() },
    new Assignment { id = 21, technician_id = 8, subscriber_id = 8, service_id = 1, status_assigment = "Completado" , Assigment_date = RandomDate()         }
);

        }
    }
}