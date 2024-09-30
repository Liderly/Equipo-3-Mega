using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

namespace backend.Models.Config
{
    public class UserConfig : IEntityTypeConfiguration<IdentityUser> // Reemplaza IdentityUser por tu modelo de usuario si has creado uno personalizado
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            // Mapea la tabla de usuarios
            builder.ToTable("Users");

            // Configura la clave primaria
            builder.HasKey(u => u.Id);

            // Configura el campo de correo electrónico
            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(256); // Longitud máxima del correo electrónico

            // Configura el campo de nombre de usuario
            builder.Property(u => u.UserName)
                   .IsRequired()
                   .HasMaxLength(256); // Longitud máxima del nombre de usuario

            // Configura la contraseña (puedes usar configuraciones adicionales según tus necesidades)
            builder.Property(u => u.PasswordHash)
                   .IsRequired();

            // Puedes agregar más configuraciones para propiedades personalizadas
            // Por ejemplo, si tienes propiedades adicionales en tu modelo de usuario
            // builder.Property(u => u.CustomProperty).HasMaxLength(100);

            // Puedes definir índices, relaciones y más
            builder.HasIndex(u => u.Email).IsUnique(); // Asegúrate de que el correo electrónico sea único

            // Si tienes roles relacionados, puedes configurar relaciones aquí
            // builder.HasMany(u => u.UserRoles)
            //        .WithOne()
            //        .HasForeignKey(ur => ur.UserId);
        }
    }
}
