using Microsoft.EntityFrameworkCore;
using Backend.Models.Config;
using Backend.Models;
namespace Backend.Context
{
    public class ContextDB : DbContext, IContextDB
    {
        public DbSet<Suscriber> Suscriber { get; set; }
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {
        }
        public int SaveChanges()
        {
            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SuscriberConfig());
        }

        public Task<int> SaveChangesAsync(bool CancellationToken, CancellationToken cancellationToken = default)
        {

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}