using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;

namespace Backend.Models.Config
{
    public class SuscriberConfig : IEntityTypeConfiguration<Suscriber>
    {
        public void Configure(EntityTypeBuilder<Suscriber> builder)
        {
            builder.ToTable("Suscriptor");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.street).IsRequired().HasMaxLength(50);
            builder.Property(x => x.number_street).IsRequired().HasColumnType("int");
            builder.Property(x => x.post_Code).IsRequired().HasColumnType("int");
            builder.Property(x => x.Zone).IsRequired().HasMaxLength(50);
            builder.Property(x => x.state).IsRequired().HasMaxLength(50);

        }
    }
}