using backend.Models;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context
{
    public interface IContextDB
    {
        DbSet<Suscriber> Subscriptors { get; set; }
        DbSet<Quadrille> Quadrilles { get; set; }
        DbSet<Technician> Technicians { get; set; }
        DbSet<ServiceCatalog> ServiceCatalogs { get; set; }
        DbSet<Assignment> Assignments { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(bool CancellationToken,CancellationToken cancellationToken = default);
    }
}