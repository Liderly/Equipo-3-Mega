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
            builder.HasIndex(x=>x.employee_number).IsUnique();

            builder.HasMany(x => x.Assignments)
                   .WithOne(x => x.Technician)
                   .HasForeignKey(x => x.technician_id);
            builder.HasIndex(x => x.employee_number);
            builder.HasIndex(x => new { x.last_name, x.name });
            builder.HasIndex(x=>x.quadrille_id);
            builder.HasData(
        new Technician { id = 1, name = "Luis", last_name = "Gomez", employee_number = 10001, quadrille_id = 1, phone = 3310194098 },
    new Technician { id = 2, name = "Laura", last_name = "Rodriguez", employee_number = 10002, quadrille_id = 1, phone = 3310194099 },
    new Technician { id = 3, name = "Carlos", last_name = "Perez", employee_number = 10003, quadrille_id = 2, phone = 3310194100 },
    new Technician { id = 4, name = "Elena", last_name = "Ramirez", employee_number = 10004, quadrille_id = 2, phone = 3310194101 },
    new Technician { id = 5, name = "Miguel", last_name = "Sanchez", employee_number = 10005, quadrille_id = 3, phone = 3310194102 },
    new Technician { id = 6, name = "Jose", last_name = "Torres", employee_number = 10006, quadrille_id = 3, phone = 3310194103 },
    new Technician { id = 7, name = "Adriana", last_name = "Diaz", employee_number = 10007, quadrille_id = 4, phone = 3310194104 },
    new Technician { id = 8, name = "Fernando", last_name = "Gutierrez", employee_number = 10008, quadrille_id = 4, phone = 3310194105 },
    new Technician { id = 9, name = "Sofia", last_name = "Mendez", employee_number = 10009, quadrille_id = 5, phone = 3310194106 },
    new Technician { id = 10, name = "Ricardo", last_name = "Ortega", employee_number = 10010, quadrille_id = 5, phone = 3310194107 },
    new Technician { id = 11, name = "Paola", last_name = "Martinez", employee_number = 10011, quadrille_id = 6, phone = 3310194108 },
    new Technician { id = 12, name = "David", last_name = "Gonzalez", employee_number = 10012, quadrille_id = 6, phone = 3310194109 },
    new Technician { id = 13, name = "Ana", last_name = "Vargas", employee_number = 10013, quadrille_id = 7, phone = 3310194110 },
    new Technician { id = 14, name = "Javier", last_name = "Castro", employee_number = 10014, quadrille_id = 7, phone = 3310194111 },
    new Technician { id = 15, name = "Mariana", last_name = "Flores", employee_number = 10015, quadrille_id = 8, phone = 3310194112 },
    new Technician { id = 16, name = "Gabriel", last_name = "Rojas", employee_number = 10016, quadrille_id = 8, phone = 3310194113 },
    new Technician { id = 17, name = "Valentina", last_name = "Herrera", employee_number = 10017, quadrille_id = 9, phone = 3310194114 },
    new Technician { id = 18, name = "Alejandro", last_name = "Morales", employee_number = 10018, quadrille_id = 9, phone = 3310194115 },
    new Technician { id = 19, name = "Isabella", last_name = "Jimenez", employee_number = 10019, quadrille_id = 10, phone = 3310194116 },
    new Technician { id = 20, name = "Daniel", last_name = "Acosta", employee_number = 10020, quadrille_id = 10, phone = 3310194117 }
    );
        }
    }
}