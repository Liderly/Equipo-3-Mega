using Microsoft.EntityFrameworkCore;
using Backend.Models.Config;
using Backend.Models;
using backend.Models;
using backend.Models.Config;
using backend.src.DTO;
using Microsoft.Data.SqlClient;
using static backend.src.DTO.BonusReport;
using backend.src.Models;
using backend.src.Models.Config;
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
        public DbSet<User> Users { get; set; }
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
            modelBuilder.ApplyConfiguration(new UserConfig());
        }

        public Task<int> SaveChangesAsync(bool CancellationToken, CancellationToken cancellationToken = default)
        {

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}