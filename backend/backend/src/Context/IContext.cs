using backend.Models;
using backend.src.DTO;
using Backend.Models;
using Microsoft.EntityFrameworkCore;
using static backend.src.DTO.BonusReport;

namespace Backend.Context
{
    public interface IContextDB
    {
        DbSet<Suscriber> Subscriptors { get; set; }
        DbSet<Quadrille> Quadrilles { get; set; }
        DbSet<Technician> Technicians { get; set; }
        DbSet<JobsCatalog> ServiceCatalogs { get; set; }
        DbSet<Assignment> Assignments { get; set; }
        DbSet<Bonus_tab> Bonus_Tabs { get; set; }
        Task<List<TechInfo>> GetBonusReportAsync(string id);
        int SaveChanges();

        Task<int> SaveChangesAsync(bool CancellationToken,CancellationToken cancellationToken = default);
    }
}