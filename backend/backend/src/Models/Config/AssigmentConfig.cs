using backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models.Config
{
    public class AssignmentConfig : IEntityTypeConfiguration<Assignment>
    {
        Random random = new Random();
        //Genera una fecha aleatoria entre el 30 de septiembre y el 1 de octubre de 2024
        DateTime RandomDate()
        {
            DateTime start = new DateTime(2024, 9, 30);
            DateTime end = new DateTime(2024, 10, 1);
            int range = (end - start).Days;
            return start.AddDays(random.Next(range + 1)).AddHours(random.Next(24)).AddMinutes(random.Next(60));

        }
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.ToTable("Assignments_orders");
            builder.HasKey(x => x.id);
            builder.Property(x => x.status_assigment).IsRequired().HasMaxLength(100).HasDefaultValue("Pendiente").HasColumnName("state_order");
            builder.Property(x => x.Assigment_date).IsRequired().HasColumnType("datetime").HasDefaultValueSql("GETDATE()").HasColumnName("date_order");
            builder.Property(x => x.Finish_date).HasColumnType("datetime").HasDefaultValue(null).HasColumnName("date_finish");
            builder.HasOne(x => x.Technician)
                   .WithMany(x => x.Assignments)
                   .HasForeignKey(x => x.technician_id);

            builder.HasOne(x => x.Subscriptor)
                   .WithMany(x => x.Assignments)
                   .HasForeignKey(x => x.subscriber_id);

            builder.HasOne(x => x.JobsCatalog)
                   .WithMany(x => x.Assignments)
                   .HasForeignKey(x => x.service_id);
            builder.HasIndex(x => x.status_assigment);
            builder.HasIndex(x => x.technician_id);
            builder.HasIndex(x => x.subscriber_id);
            builder.HasIndex(x => x.service_id);
            builder.HasData(
     new Assignment { id = 1, technician_id = 1, subscriber_id = 1, service_id = 1, status_assigment = "Pendiente", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 2, technician_id = 2, subscriber_id = 2, service_id = 2, status_assigment = "Completado", Assigment_date = RandomDate(), Finish_date = RandomDate().AddDays(1) },
            new Assignment { id = 3, technician_id = 2, subscriber_id = 2, service_id = 2, status_assigment = "Completado", Assigment_date = RandomDate(), Finish_date = RandomDate().AddDays(1) },
            new Assignment { id = 4, technician_id = 3, subscriber_id = 3, service_id = 3, status_assigment = "En Progreso", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 5, technician_id = 4, subscriber_id = 4, service_id = 4, status_assigment = "Pendiente", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 6, technician_id = 5, subscriber_id = 5, service_id = 5, status_assigment = "Completado", Assigment_date = RandomDate(), Finish_date = RandomDate().AddDays(1) },
            new Assignment { id = 7, technician_id = 6, subscriber_id = 6, service_id = 6, status_assigment = "En Progreso", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 8, technician_id = 7, subscriber_id = 7, service_id = 7, status_assigment = "Pendiente", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 9, technician_id = 8, subscriber_id = 8, service_id = 8, status_assigment = "Completado", Assigment_date = RandomDate(), Finish_date = RandomDate().AddDays(1) },
            new Assignment { id = 10, technician_id = 9, subscriber_id = 9, service_id = 9, status_assigment = "En Progreso", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 11, technician_id = 10, subscriber_id = 10, service_id = 10, status_assigment = "Pendiente", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 12, technician_id = 11, subscriber_id = 11, service_id = 11, status_assigment = "Completado", Assigment_date = RandomDate(), Finish_date = RandomDate().AddDays(1) },
            new Assignment { id = 13, technician_id = 12, subscriber_id = 12, service_id = 12, status_assigment = "En Progreso", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 14, technician_id = 1, subscriber_id = 1, service_id = 13, status_assigment = "Pendiente", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 15, technician_id = 2, subscriber_id = 2, service_id = 14, status_assigment = "Completado", Assigment_date = RandomDate(), Finish_date = RandomDate().AddDays(1) },
            new Assignment { id = 16, technician_id = 3, subscriber_id = 3, service_id = 15, status_assigment = "En Progreso", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 17, technician_id = 4, subscriber_id = 4, service_id = 16, status_assigment = "Pendiente", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 18, technician_id = 5, subscriber_id = 5, service_id = 17, status_assigment = "Completado", Assigment_date = RandomDate(), Finish_date = RandomDate().AddDays(1) },
            new Assignment { id = 19, technician_id = 6, subscriber_id = 6, service_id = 5, status_assigment = "Pendiente", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 20, technician_id = 7, subscriber_id = 7, service_id = 2, status_assigment = "En Progreso", Assigment_date = RandomDate(), Finish_date = null },
            new Assignment { id = 21, technician_id = 8, subscriber_id = 8, service_id = 1, status_assigment = "Completado", Assigment_date = RandomDate(), Finish_date = RandomDate().AddDays(1) }
);

        }
    }
}