using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace backend.Models.Config
{
    public class JobsCatalogConfig : IEntityTypeConfiguration<JobsCatalog>
    {
        public void Configure(EntityTypeBuilder<JobsCatalog> builder)
        {
            builder.ToTable("jobs_catalog");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.duration).IsRequired();
            builder.Property(x => x.description).IsRequired().HasMaxLength(100);
            builder.Property(x => x.points).IsRequired();

            builder.HasMany(x => x.Assignments)
                   .WithOne(x => x.JobsCatalog)
                   .HasForeignKey(x => x.service_id);
            builder.HasIndex(x => x.name);
            builder.HasIndex(x => x.points);
            builder.HasData(
                  // Servicios de Telefonía
                 new JobsCatalog { id = 1, name = "Instalación de Línea Telefónica", duration = 2, description = "Instalación y activación de línea telefónica residencial.", points = 50 },
                 new JobsCatalog { id = 2, name = "Reparación de Línea Telefónica", duration = 1, description = "Resolución de problemas en la línea telefónica.", points = 40 },
                 new JobsCatalog {id = 3, name = "Cambio de Número Telefónico", duration = 1, description = "Cambio de número telefónico en la misma línea.", points = 30 },
                 new JobsCatalog {id = 4, name = "Configuración de Teléfono Fijo", duration = 1, description = "Configuración de funciones en teléfono fijo.", points = 20 },
                 // Servicios de Internet
                 new JobsCatalog { id = 5,  name = "Instalación de Internet", duration = 3, description = "Instalación de modem y activación del servicio de internet.", points = 80 },
                 new JobsCatalog {id = 6, name = "Mantenimiento de Internet", duration = 1, description = "Revisión y mantenimiento preventivo del equipo de internet.", points = 30 },
                 new JobsCatalog {id = 7, name = "Configuración de Red Wi-Fi", duration = 2, description = "Configuración de la red Wi-Fi y dispositivos conectados.", points = 60 },
                 new JobsCatalog {id = 8, name = "Cambio de Modem", duration = 1, description = "Cambio de equipo por actualización o mal funcionamiento.", points = 40 },
                 new JobsCatalog {id = 9, name = "Soporte Técnico de Internet", duration = 1, description = "Asistencia remota o en sitio para problemas de internet.", points = 30 },
                 // Servicios de Cable
                 new JobsCatalog {id = 10, name = "Instalación de TV Básica", duration = 2, description = "Instalación de decodificador y activación de canales básicos.", points = 50 },
                 new JobsCatalog {id = 11, name = "Instalación de TV Premium", duration = 3, description = "Instalación de decodificador y activación de canales premium.", points = 80 },
                 new JobsCatalog {id = 12, name = "Reparación de Señal de TV", duration = 1, description = "Resolución de problemas con la señal de televisión.", points = 40 },
                 new JobsCatalog {id = 13, name = "Cambio de Decodificador", duration = 1, description = "Cambio de equipo por actualización o mal funcionamiento.", points = 40 },
                 new JobsCatalog {id = 14, name = "Configuración de Canales", duration = 1, description = "Configuración y personalización de canales de TV.", points = 30 },
                 // Servicios Combinados
                 new JobsCatalog {id = 15, name = "Paquete Triple Play", duration = 4, description = "Instalación de servicio de telefonía, internet y TV.", points = 120 },
                 new JobsCatalog {id = 16, name = "Actualización de Servicios", duration = 2, description = "Actualización de servicios combinados de telefonía, internet y TV.", points = 70 },
                 new JobsCatalog {id = 17, name = "Soporte Integral de Servicios", duration = 2, description = "Asistencia técnica para problemas en servicios combinados.", points = 50 }
                );
        }
    }
}