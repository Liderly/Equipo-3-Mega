using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;

namespace Backend.Models.Config
{
    public class SubscriberConfig : IEntityTypeConfiguration<Suscriber>
    {
        public void Configure(EntityTypeBuilder<Suscriber> builder)
        {
            builder.ToTable("Subscriptor");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.last_name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.street).IsRequired().HasMaxLength(255);
            builder.Property(x => x.post_code).IsRequired();
            builder.Property(x => x.zone).IsRequired().HasMaxLength(250);

            builder.HasMany(x => x.Assignments)
                   .WithOne(x => x.Subscriptor)
                   .HasForeignKey(x => x.subscriber_id);
            builder.HasIndex(x => x.post_code);
            builder.HasIndex(x => x.zone);
            builder.HasIndex(x => new { x.last_name, x.name });
            builder.HasData(
    new Suscriber { id = 1, number = 1, name = "Juan", last_name = "Garcia", street = "Calle 1", street_number = "1219", post_code = 12345, zone = "Zona Norte", phone = 3919890119 },
    new Suscriber { id = 2, number = 2, name = "Maria", last_name = "Hernandez", street = "Calle 2", street_number = "2468", post_code = 12346, zone = "Zona Sur", phone = 3919890120 },
    new Suscriber { id = 3, number = 3, name = "Pedro", last_name = "Lopez", street = "Calle 3", street_number = "3579", post_code = 12347, zone = "Zona Este", phone = 3919890121 },
    new Suscriber { id = 4, number = 4, name = "Ana", last_name = "Martinez", street = "Calle 4", street_number = "4680", post_code = 12348, zone = "Zona Oeste", phone = 3919890122 },
    new Suscriber { id = 5, number = 5, name = "Luis", last_name = "Gomez", street = "Calle 5", street_number = "5791", post_code = 12349, zone = "Zona Centro", phone = 3919890123 },
    new Suscriber { id = 6, number = 6, name = "Laura", last_name = "Rodriguez", street = "Calle 6", street_number = "6802", post_code = 12350, zone = "Zona Norte", phone = 3919890124 },
    new Suscriber { id = 7, number = 7, name = "Carlos", last_name = "Perez", street = "Calle 7", street_number = "7913", post_code = 12351, zone = "Zona Sur", phone = 3919890125 },
    new Suscriber { id = 8, number = 8, name = "Elena", last_name = "Ramirez", street = "Calle 8", street_number = "8024", post_code = 12352, zone = "Zona Este", phone = 3919890126 },
    new Suscriber { id = 9, number = 9, name = "Miguel", last_name = "Sanchez", street = "Calle 9", street_number = "9135", post_code = 12353, zone = "Zona Oeste", phone = 3919890127 },
    new Suscriber { id = 10, number = 10, name = "Jose", last_name = "Torres", street = "Calle 10", street_number = "1046", post_code = 12354, zone = "Zona Centro", phone = 3919890128 },
    new Suscriber { id = 11, number = 11, name = "Adriana", last_name = "Diaz", street = "Calle 11", street_number = "1157", post_code = 12355, zone = "Zona Norte", phone = 3919890129 },
    new Suscriber { id = 12, number = 12, name = "Fernando", last_name = "Gutierrez", street = "Calle 12", street_number = "1268", post_code = 12356, zone = "Zona Sur", phone = 3919890130 },
    new Suscriber { id = 13, number = 13, name = "Sofia", last_name = "Vazquez", street = "Avenida Principal", street_number = "2435", post_code = 12357, zone = "Zona Noreste", phone = 3919890131 },
    new Suscriber { id = 14, number = 14, name = "Roberto", last_name = "Fernandez", street = "Boulevard Central", street_number = "789", post_code = 12358, zone = "Zona Sureste", phone = 3919890132 },
    new Suscriber { id = 15, number = 15, name = "Carmen", last_name = "Ortega", street = "Paseo de la Reforma", street_number = "5012", post_code = 12359, zone = "Zona Noroeste", phone = 3919890133 },
    new Suscriber { id = 16, number = 16, name = "Javier", last_name = "Morales", street = "Calzada de los Heroes", street_number = "1670", post_code = 12360, zone = "Zona Suroeste", phone = 3919890134 },
    new Suscriber { id = 17, number = 17, name = "Gabriela", last_name = "Castillo", street = "Circuito Interior", street_number = "3845", post_code = 12361, zone = "Zona Metropolitana", phone = 3919890135 },
    new Suscriber { id = 18, number = 18, name = "Alejandro", last_name = "Ruiz", street = "Avenida Insurgentes", street_number = "9276", post_code = 12362, zone = "Zona Histórica", phone = 3919890136 },
    new Suscriber { id = 19, number = 19, name = "Patricia", last_name = "Mendoza", street = "Calle del Bosque", street_number = "4523", post_code = 12363, zone = "Zona Residencial", phone = 3919890137 },
    new Suscriber { id = 20, number = 20, name = "Ricardo", last_name = "Vargas", street = "Avenida de las Flores", street_number = "6789", post_code = 12364, zone = "Zona Comercial", phone = 3919890138 }
);
        }
    }
}