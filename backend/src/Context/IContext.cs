using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context
{
    public interface IContextDB
    {
        DbSet<Suscriber> Suscriber { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(bool CancellationToken,CancellationToken cancellationToken = default);
    }
}