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
            builder.Property(x => x.post_Code).IsRequired();
            builder.Property(x => x.zone_sub).IsRequired().HasMaxLength(250);

            builder.HasMany(x => x.Assignments)
                   .WithOne(x => x.Subscriptor)
                   .HasForeignKey(x => x.subscriber_id);
            builder.HasIndex(x => x.post_Code);
            builder.HasIndex(x => x.zone_sub);
            builder.HasIndex(x => new { x.last_name, x.name });
            builder.HasData(
                new Suscriber { id = 1, name = "Juan", last_name = "Garcia", street = "Calle 1", post_Code = 12345, zone_sub = "Zona Norte" },
                new Suscriber { id = 2, name = "Maria", last_name = "Hernandez", street = "Calle 2", post_Code = 12346, zone_sub = "Zona Sur" },
                new Suscriber { id = 3, name = "Pedro", last_name = "Lopez", street = "Calle 3", post_Code = 12347, zone_sub = "Zona Este" },
                new Suscriber { id = 4, name = "Ana", last_name = "Martinez", street = "Calle 4", post_Code = 12348, zone_sub = "Zona Oeste" },
                new Suscriber { id = 5, name = "Luis", last_name = "Gomez", street = "Calle 5", post_Code = 12349, zone_sub = "Zona Centro" },
                new Suscriber { id = 6, name = "Laura", last_name = "Rodriguez", street = "Calle 6", post_Code = 12350, zone_sub = "Zona Norte" },
                new Suscriber { id = 7, name = "Carlos", last_name = "Perez", street = "Calle 7", post_Code = 12351, zone_sub = "Zona Sur" },
                new Suscriber { id = 8, name = "Elena", last_name = "Ramirez", street = "Calle 8", post_Code = 12352, zone_sub = "Zona Este" },
                new Suscriber { id = 9, name = "Miguel", last_name = "Sanchez", street = "Calle 9", post_Code = 12353, zone_sub = "Zona Oeste" },
                new Suscriber { id = 10, name = "Jose", last_name = "Torres", street = "Calle 10", post_Code = 12354, zone_sub = "Zona Centro" },
                new Suscriber { id = 11, name = "Adriana", last_name = "Diaz", street = "Calle 11", post_Code = 12355, zone_sub = "Zona Norte" },
                new Suscriber { id = 12, name = "Fernando", last_name = "Gutierrez", street = "Calle 12", post_Code = 12356, zone_sub = "Zona Sur" }
                );
        }
    }
}