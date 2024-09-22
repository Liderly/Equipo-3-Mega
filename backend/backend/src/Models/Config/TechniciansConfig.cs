using backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Backend.Models.Config
{
    public class TechnicianConfig : IEntityTypeConfiguration<Technician>
    {
        public void Configure(EntityTypeBuilder<Technician> builder)
        {
            builder.ToTable("Technicians");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.last_name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.employee_number).IsRequired();

            builder.HasMany(x => x.Assignments)
                   .WithOne(x => x.Technician)
                   .HasForeignKey(x => x.technician_id);
            builder.HasIndex(x => x.employee_number);
            builder.HasIndex(x => new { x.last_name, x.name });
            builder.HasIndex(x=>x.quadrille_id);
            builder.HasData(
        new Technician { id = 1, name = "Luis", last_name = "Gomez", employee_number = 10001, quadrille_id = 1 },
        new Technician { id = 2, name = "Laura", last_name = "Rodriguez", employee_number = 10002, quadrille_id = 2 },
        new Technician {id = 3, name = "Carlos", last_name = "Perez", employee_number = 10003, quadrille_id = 3 },
        new Technician {id = 4, name = "Elena", last_name = "Ramirez", employee_number = 10004, quadrille_id = 4 },
        new Technician {id = 5, name = "Miguel", last_name = "Sanchez", employee_number = 10005, quadrille_id = 5 },
        new Technician {id = 6, name = "Jose", last_name = "Torres", employee_number = 10006, quadrille_id = 6 },
        new Technician {id = 7, name = "Adriana", last_name = "Diaz", employee_number = 10007, quadrille_id = 7 },
        new Technician {id = 8, name = "Fernando", last_name = "Gutierrez", employee_number = 10008, quadrille_id = 8 },
        new Technician {id = 9, name = "Sofia", last_name = "Mendez", employee_number = 10009, quadrille_id = 9 },
        new Technician {id = 10, name = "Ricardo", last_name = "Ortega", employee_number = 10010, quadrille_id = 10 },
        new Technician {id = 11, name = "Paola", last_name = "Martinez", employee_number = 10011, quadrille_id = 11 },
        new Technician {id = 12, name = "David", last_name = "Gonzalez", employee_number = 10012, quadrille_id = 12 }
    );
        }
    }
}