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
                  // Servicios de Telefon�a
                 new JobsCatalog { id = 1, name = "Instalaci�n de L�nea Telef�nica", duration = 2, description = "Instalaci�n y activaci�n de l�nea telef�nica residencial.", points = 50 },
                 new JobsCatalog { id = 2, name = "Reparaci�n de L�nea Telef�nica", duration = 1, description = "Resoluci�n de problemas en la l�nea telef�nica.", points = 40 },
                 new JobsCatalog {id = 3, name = "Cambio de N�mero Telef�nico", duration = 1, description = "Cambio de n�mero telef�nico en la misma l�nea.", points = 30 },
                 new JobsCatalog {id = 4, name = "Configuraci�n de Tel�fono Fijo", duration = 1, description = "Configuraci�n de funciones en tel�fono fijo.", points = 20 },
                 // Servicios de Internet
                 new JobsCatalog { id = 5,  name = "Instalaci�n de Internet", duration = 3, description = "Instalaci�n de modem y activaci�n del servicio de internet.", points = 80 },
                 new JobsCatalog {id = 6, name = "Mantenimiento de Internet", duration = 1, description = "Revisi�n y mantenimiento preventivo del equipo de internet.", points = 30 },
                 new JobsCatalog {id = 7, name = "Configuraci�n de Red Wi-Fi", duration = 2, description = "Configuraci�n de la red Wi-Fi y dispositivos conectados.", points = 60 },
                 new JobsCatalog {id = 8, name = "Cambio de Modem", duration = 1, description = "Cambio de equipo por actualizaci�n o mal funcionamiento.", points = 40 },
                 new JobsCatalog {id = 9, name = "Soporte T�cnico de Internet", duration = 1, description = "Asistencia remota o en sitio para problemas de internet.", points = 30 },
                 // Servicios de Cable
                 new JobsCatalog {id = 10, name = "Instalaci�n de TV B�sica", duration = 2, description = "Instalaci�n de decodificador y activaci�n de canales b�sicos.", points = 50 },
                 new JobsCatalog {id = 11, name = "Instalaci�n de TV Premium", duration = 3, description = "Instalaci�n de decodificador y activaci�n de canales premium.", points = 80 },
                 new JobsCatalog {id = 12, name = "Reparaci�n de Se�al de TV", duration = 1, description = "Resoluci�n de problemas con la se�al de televisi�n.", points = 40 },
                 new JobsCatalog {id = 13, name = "Cambio de Decodificador", duration = 1, description = "Cambio de equipo por actualizaci�n o mal funcionamiento.", points = 40 },
                 new JobsCatalog {id = 14, name = "Configuraci�n de Canales", duration = 1, description = "Configuraci�n y personalizaci�n de canales de TV.", points = 30 },
                 // Servicios Combinados
                 new JobsCatalog {id = 15, name = "Paquete Triple Play", duration = 4, description = "Instalaci�n de servicio de telefon�a, internet y TV.", points = 120 },
                 new JobsCatalog {id = 16, name = "Actualizaci�n de Servicios", duration = 2, description = "Actualizaci�n de servicios combinados de telefon�a, internet y TV.", points = 70 },
                 new JobsCatalog {id = 17, name = "Soporte Integral de Servicios", duration = 2, description = "Asistencia t�cnica para problemas en servicios combinados.", points = 50 }
                );
        }
    }
}