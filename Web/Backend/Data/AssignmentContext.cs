using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Web.Backend.Models;
using Microsoft.Extensions.Configuration;

namespace Web.Backend.Data
{
    public class AssignmentContext(DbContextOptions<AssignmentContext> builder) : DbContext(builder)
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Document>();
            modelBuilder.Entity<User>();
        }
    }
}
