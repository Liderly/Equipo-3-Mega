using backend.Models;
using backend.src.Models;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context
{
    public interface IContextDB
    {
        DbSet<Suscriber> Subscriptors { get; set; }
        DbSet<Quadrille> Quadrilles { get; set; }
        DbSet<Technician> Technicians { get; set; }
        DbSet<JobsCatalog> ServiceCatalogs { get; set; }
        DbSet<Assignment> Assignments { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Bonus_tab> Bonus_Tabs { get; set; }
        int SaveChanges();

        Task<int> SaveChangesAsync(bool CancellationToken,CancellationToken cancellationToken = default);
    }
}