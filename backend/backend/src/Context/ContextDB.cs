using Microsoft.EntityFrameworkCore;
using Backend.Models.Config;
using Backend.Models;
using backend.Models;
using backend.Models.Config;
using backend.src.DTO;
using Microsoft.Data.SqlClient;
using static backend.src.DTO.BonusReport;
namespace Backend.Context
{
    public class ContextDB : DbContext, IContextDB
    {
        public DbSet<Suscriber> Subscriptors { get; set; }
        public DbSet<Quadrille> Quadrilles { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<JobsCatalog> ServiceCatalogs { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Bonus_tab> Bonus_Tabs { get; set; }
        public DbSet<TechInfo> TechInfos { get; set; }
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {
        }
        public int SaveChanges()
        {
            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SubscriberConfig());
            modelBuilder.ApplyConfiguration(new QuadrilleConfig());
            modelBuilder.ApplyConfiguration(new TechnicianConfig());
            modelBuilder.ApplyConfiguration(new JobsCatalogConfig());
            modelBuilder.ApplyConfiguration(new AssignmentConfig());
            modelBuilder.ApplyConfiguration(new Bonus_tab_Config());
            
            modelBuilder.Entity<TechInfo>().HasNoKey().ToView(null);
            modelBuilder.Entity<Tasks>().HasNoKey().ToView(null);
        }

        public Task<int> SaveChangesAsync(bool CancellationToken, CancellationToken cancellationToken = default)
        {

            return base.SaveChangesAsync(cancellationToken);
        }
        public async Task<List<TechInfo>> GetBonusReportAsync(string id="")
        {
            // Definir parámetros para el procedimiento almacenado
            var techIdParam = new SqlParameter("@TechId", id);
                var results = await this.Set<TechInfo>()
                    .FromSqlRaw("EXEC sp_getBonusReport")
                    .ToListAsync();
                return results;
            }
            
            
        
    }
}