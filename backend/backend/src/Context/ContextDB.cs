using Microsoft.EntityFrameworkCore;
using Backend.Models.Config;
using Backend.Models;
using backend.Models;
using backend.Models.Config;
namespace Backend.Context
{
    public class ContextDB : DbContext, IContextDB
    {
        public DbSet<Suscriber> Subscriptors { get; set; }
        public DbSet<Quadrille> Quadrilles { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<ServiceCatalog> ServiceCatalogs { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
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
            modelBuilder.ApplyConfiguration(new ServiceCatalogConfig());
            modelBuilder.ApplyConfiguration(new AssignmentConfig());
        }

        public Task<int> SaveChangesAsync(bool CancellationToken, CancellationToken cancellationToken = default)
        {

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}