using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options) : base(options)
        {
        }

        public DbSet<Stockboards_master> Stockboards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        } 
    }
}
