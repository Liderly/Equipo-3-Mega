using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace backend.Models.Config
{
    public class ServiceCatalogConfig : IEntityTypeConfiguration<ServiceCatalog>
    {
        public void Configure(EntityTypeBuilder<ServiceCatalog> builder)
        {
            builder.ToTable("ServiceCatalog");
            builder.HasKey(x => x.id);
            builder.Property(x => x.service_name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.duration).IsRequired();
            builder.Property(x => x.description_service).IsRequired().HasMaxLength(100);
            builder.Property(x => x.points).IsRequired();

            builder.HasMany(x => x.Assignments)
                   .WithOne(x => x.ServiceCatalog)
                   .HasForeignKey(x => x.service_id);
            builder.HasIndex(x => x.service_name);
            builder.HasIndex(x => x.points);
            builder.HasData(
                  // Servicios de Telefon�a
                 new ServiceCatalog { id = 1, service_name = "Instalaci�n de L�nea Telef�nica", duration = 2, description_service = "Instalaci�n y activaci�n de l�nea telef�nica residencial.", points = 5 },
                 new ServiceCatalog { id = 2, service_name = "Reparaci�n de L�nea Telef�nica", duration = 1, description_service = "Resoluci�n de problemas en la l�nea telef�nica.", points = 4 },
                 new ServiceCatalog {id = 3, service_name = "Cambio de N�mero Telef�nico", duration = 1, description_service = "Cambio de n�mero telef�nico en la misma l�nea.", points = 3 },
                 new ServiceCatalog {id = 4, service_name = "Configuraci�n de Tel�fono Fijo", duration = 1, description_service = "Configuraci�n de funciones en tel�fono fijo.", points = 2 },
                 // Servicios de Internet
                 new ServiceCatalog {id = 5, service_name = "Instalaci�n de Internet", duration = 3, description_service = "Instalaci�n de modem y activaci�n del servicio de internet.", points = 8 },
                 new ServiceCatalog {id = 6, service_name = "Mantenimiento de Internet", duration = 1, description_service = "Revisi�n y mantenimiento preventivo del equipo de internet.", points = 3 },
                 new ServiceCatalog {id = 7, service_name = "Configuraci�n de Red Wi-Fi", duration = 2, description_service = "Configuraci�n de la red Wi-Fi y dispositivos conectados.", points = 6 },
                 new ServiceCatalog {id = 8, service_name = "Cambio de Modem", duration = 1, description_service = "Cambio de equipo por actualizaci�n o mal funcionamiento.", points = 4 },
                 new ServiceCatalog {id = 9, service_name = "Soporte T�cnico de Internet", duration = 1, description_service = "Asistencia remota o en sitio para problemas de internet.", points = 3 },
                 // Servicios de Cable
                 new ServiceCatalog {id = 10, service_name = "Instalaci�n de TV B�sica", duration = 2, description_service = "Instalaci�n de decodificador y activaci�n de canales b�sicos.", points = 5 },
                 new ServiceCatalog {id = 11, service_name = "Instalaci�n de TV Premium", duration = 3, description_service = "Instalaci�n de decodificador y activaci�n de canales premium.", points = 8 },
                 new ServiceCatalog {id = 12, service_name = "Reparaci�n de Se�al de TV", duration = 1, description_service = "Resoluci�n de problemas con la se�al de televisi�n.", points = 4 },
                 new ServiceCatalog {id = 13, service_name = "Cambio de Decodificador", duration = 1, description_service = "Cambio de equipo por actualizaci�n o mal funcionamiento.", points = 4 },
                 new ServiceCatalog {id = 14, service_name = "Configuraci�n de Canales", duration = 1, description_service = "Configuraci�n y personalizaci�n de canales de TV.", points = 3 },
                 // Servicios Combinados
                 new ServiceCatalog {id = 15, service_name = "Paquete Triple Play", duration = 4, description_service = "Instalaci�n de servicio de telefon�a, internet y TV.", points = 12 },
                 new ServiceCatalog {id = 16, service_name = "Actualizaci�n de Servicios", duration = 2, description_service = "Actualizaci�n de servicios combinados de telefon�a, internet y TV.", points = 7 },
                 new ServiceCatalog {id = 17, service_name = "Soporte Integral de Servicios", duration = 2, description_service = "Asistencia t�cnica para problemas en servicios combinados.", points = 5 }
                );
        }
    }
}