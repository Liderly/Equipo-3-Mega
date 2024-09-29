using backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Backend.Models.Config
{
    public class QuadrilleConfig : IEntityTypeConfiguration<Quadrille>
    {
        public void Configure(EntityTypeBuilder<Quadrille> builder)
        {
            builder.ToTable("Quadrille");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.quadrille_number).IsRequired();

            builder.HasMany(x => x.Technicians)
                   .WithOne(x => x.Quadrille)
                   .HasForeignKey(x => x.quadrille_id);
            builder.HasIndex(x => x.quadrille_number);
            builder.HasData(
       new Quadrille { Id = 1, quadrille_number = 1001 },
       new Quadrille { Id = 2, quadrille_number = 1002  },
       new Quadrille { Id = 3, quadrille_number = 1003 },
       new Quadrille { Id = 4, quadrille_number = 1004},
       new Quadrille { Id = 5, quadrille_number = 1005 },
       new Quadrille { Id = 6, quadrille_number = 1006 },
       new Quadrille { Id = 7, quadrille_number = 1007},
       new Quadrille { Id = 8, quadrille_number = 1008 },
       new Quadrille { Id = 9, quadrille_number = 1009},
       new Quadrille { Id = 10, quadrille_number = 1010 }
   );
        }
    }
}