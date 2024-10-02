
using backend.src.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.src.Models.Config
{
    public class UserConfig:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.role).IsRequired();
            builder.Property(x => x.email).IsRequired().HasMaxLength(255);
            builder.Property(x => x.password).IsRequired().HasMaxLength(255);
            builder.HasIndex(x => x.email).IsUnique();
            builder.HasIndex(x=>x.num_emp).IsUnique();
            builder.HasData(
            new User { num_emp = 1, Id = 1, role = "Admin", email = "admin@megacable.com.mx", password = PasswordHasher.HashPassword("admin123") },
            new User { num_emp = 10001, Id = 2, role = "Tecnico", email = "luis.gomez@megacable.com.mx", password = PasswordHasher.HashPassword("luis123") },
            new User { num_emp = 10002, Id = 3, role = "Tecnico", email = "laura.rodriguez@megacable.com.mx", password = PasswordHasher.HashPassword("laura123") },
            new User { num_emp = 10003, Id = 4, role = "Tecnico", email = "carlos.perez@megacable.com.mx", password = PasswordHasher.HashPassword("carlos123") },
            new User { num_emp = 10004, Id = 5, role = "Tecnico", email = "elena.ramirez@megacable.com.mx", password = PasswordHasher.HashPassword("elena123") },
            new User { num_emp = 10005, Id = 6, role = "Tecnico", email = "miguel.sanchez@megacable.com.mx", password = PasswordHasher.HashPassword("miguel123") },
            new User { num_emp = 10006, Id = 7, role = "Tecnico", email = "jose.torres@megacable.com.mx", password = PasswordHasher.HashPassword("jose123") },
            new User { num_emp = 10007, Id = 8, role = "Tecnico", email = "adriana.diaz@megacable.com.mx", password = PasswordHasher.HashPassword("adriana123") },
            new User { num_emp = 10008, Id = 9, role = "Tecnico", email = "fernando.gutierrez@megacable.com.mx", password = PasswordHasher.HashPassword("fernando123") },
            new User { num_emp = 10009, Id = 10, role = "Tecnico", email = "sofia.mendez@megacable.com.mx", password = PasswordHasher.HashPassword("sofia123") },
            new User { num_emp = 10010, Id = 11, role = "Tecnico", email = "ricardo.ortega@megacable.com.mx", password = PasswordHasher.HashPassword("ricardo123") },
            new User { num_emp = 10011, Id = 12, role = "Tecnico", email = "paola.martinez@megacable.com.mx", password = PasswordHasher.HashPassword("paola123") },
            new User { num_emp = 10012, Id = 13, role = "Tecnico", email = "david.gonzalez@megacable.com.mx", password = PasswordHasher.HashPassword("david123") },
            new User { num_emp = 10013, Id = 14, role = "Tecnico", email = "ana.vargas@megacable.com.mx", password = PasswordHasher.HashPassword("ana123") },
            new User { num_emp = 10014, Id = 15, role = "Tecnico", email = "javier.castro@megacable.com.mx", password = PasswordHasher.HashPassword("javier123") },
            new User { num_emp = 10015, Id = 16, role = "Tecnico", email = "mariana.flores@megacable.com.mx", password = PasswordHasher.HashPassword("mariana123") },
            new User { num_emp = 10016, Id = 17, role = "Tecnico", email = "gabriel.rojas@megacable.com.mx", password = PasswordHasher.HashPassword("gabriel123") },
            new User { num_emp = 10017, Id = 18, role = "Tecnico", email = "valentina.herrera@megacable.com.mx", password = PasswordHasher.HashPassword("valentina123") },
            new User { num_emp = 10018, Id = 19, role = "Tecnico", email = "alejandro.morales@megacable.com.mx", password = PasswordHasher.HashPassword("alejandro123") },
            new User { num_emp = 10019, Id = 20, role = "Tecnico", email = "isabella.jimenez@megacable.com.mx", password = PasswordHasher.HashPassword("isabella123") },
            new User { num_emp = 10020, Id = 21, role = "Tecnico", email = "daniel.acosta@megacable.com.mx", password = PasswordHasher.HashPassword("daniel123") });
        }
    }
}
