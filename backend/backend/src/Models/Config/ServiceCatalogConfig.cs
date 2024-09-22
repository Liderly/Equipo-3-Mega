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
                  // Servicios de Telefonía
                 new ServiceCatalog { id = 1, service_name = "Instalación de Línea Telefónica", duration = 2, description_service = "Instalación y activación de línea telefónica residencial.", points = 5 },
                 new ServiceCatalog { id = 2, service_name = "Reparación de Línea Telefónica", duration = 1, description_service = "Resolución de problemas en la línea telefónica.", points = 4 },
                 new ServiceCatalog {id = 3, service_name = "Cambio de Número Telefónico", duration = 1, description_service = "Cambio de número telefónico en la misma línea.", points = 3 },
                 new ServiceCatalog {id = 4, service_name = "Configuración de Teléfono Fijo", duration = 1, description_service = "Configuración de funciones en teléfono fijo.", points = 2 },
                 // Servicios de Internet
                 new ServiceCatalog {id = 5, service_name = "Instalación de Internet", duration = 3, description_service = "Instalación de modem y activación del servicio de internet.", points = 8 },
                 new ServiceCatalog {id = 6, service_name = "Mantenimiento de Internet", duration = 1, description_service = "Revisión y mantenimiento preventivo del equipo de internet.", points = 3 },
                 new ServiceCatalog {id = 7, service_name = "Configuración de Red Wi-Fi", duration = 2, description_service = "Configuración de la red Wi-Fi y dispositivos conectados.", points = 6 },
                 new ServiceCatalog {id = 8, service_name = "Cambio de Modem", duration = 1, description_service = "Cambio de equipo por actualización o mal funcionamiento.", points = 4 },
                 new ServiceCatalog {id = 9, service_name = "Soporte Técnico de Internet", duration = 1, description_service = "Asistencia remota o en sitio para problemas de internet.", points = 3 },
                 // Servicios de Cable
                 new ServiceCatalog {id = 10, service_name = "Instalación de TV Básica", duration = 2, description_service = "Instalación de decodificador y activación de canales básicos.", points = 5 },
                 new ServiceCatalog {id = 11, service_name = "Instalación de TV Premium", duration = 3, description_service = "Instalación de decodificador y activación de canales premium.", points = 8 },
                 new ServiceCatalog {id = 12, service_name = "Reparación de Señal de TV", duration = 1, description_service = "Resolución de problemas con la señal de televisión.", points = 4 },
                 new ServiceCatalog {id = 13, service_name = "Cambio de Decodificador", duration = 1, description_service = "Cambio de equipo por actualización o mal funcionamiento.", points = 4 },
                 new ServiceCatalog {id = 14, service_name = "Configuración de Canales", duration = 1, description_service = "Configuración y personalización de canales de TV.", points = 3 },
                 // Servicios Combinados
                 new ServiceCatalog {id = 15, service_name = "Paquete Triple Play", duration = 4, description_service = "Instalación de servicio de telefonía, internet y TV.", points = 12 },
                 new ServiceCatalog {id = 16, service_name = "Actualización de Servicios", duration = 2, description_service = "Actualización de servicios combinados de telefonía, internet y TV.", points = 7 },
                 new ServiceCatalog {id = 17, service_name = "Soporte Integral de Servicios", duration = 2, description_service = "Asistencia técnica para problemas en servicios combinados.", points = 5 }
                );
        }
    }
}