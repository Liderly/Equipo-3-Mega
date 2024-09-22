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
            builder.Property(x => x.region).IsRequired().HasMaxLength(100);
            builder.Property(x => x.branch_office).IsRequired().HasMaxLength(100);
            builder.Property(x => x.state_quadrille).IsRequired().HasMaxLength(100);

            builder.HasMany(x => x.Technicians)
                   .WithOne(x => x.Quadrille)
                   .HasForeignKey(x => x.quadrille_id);
            builder.HasIndex(x => x.quadrille_number);
            builder.HasIndex(x => x.region);
            builder.HasIndex(x => x.state_quadrille);
            builder.HasData(
       new Quadrille { Id = 1, quadrille_number = 1001, region = "Norte", branch_office = "Sucursal 1", state_quadrille = "Estado 1" },
       new Quadrille { Id = 2, quadrille_number = 1002, region = "Sur", branch_office = "Sucursal 2", state_quadrille = "Estado 2" },
       new Quadrille { Id = 3, quadrille_number = 1003, region = "Este", branch_office = "Sucursal 3", state_quadrille = "Estado 3" },
       new Quadrille { Id = 4, quadrille_number = 1004, region = "Oeste", branch_office = "Sucursal 4", state_quadrille = "Estado 4" },
       new Quadrille { Id = 5, quadrille_number = 1005, region = "Centro", branch_office = "Sucursal 5", state_quadrille = "Estado 5" },
       new Quadrille { Id = 6, quadrille_number = 1006, region = "Noroeste", branch_office = "Sucursal 6", state_quadrille = "Estado 6" },
       new Quadrille { Id = 7, quadrille_number = 1007, region = "Sureste", branch_office = "Sucursal 7", state_quadrille = "Estado 7" },
       new Quadrille { Id = 8, quadrille_number = 1008, region = "Noreste", branch_office = "Sucursal 8", state_quadrille = "Estado 8" },
       new Quadrille { Id = 9, quadrille_number = 1009, region = "Suroeste", branch_office = "Sucursal 9", state_quadrille = "Estado 9" },
       new Quadrille { Id = 10, quadrille_number = 1010, region = "Nororiente", branch_office = "Sucursal 10", state_quadrille = "Estado 10" },
       new Quadrille { Id = 11, quadrille_number = 1011, region = "Suroriente", branch_office = "Sucursal 11", state_quadrille = "Estado 11" },
       new Quadrille { Id = 12, quadrille_number = 1012, region = "Noroccidente", branch_office = "Sucursal 12", state_quadrille = "Estado 12" }
   );
        }
    }
}