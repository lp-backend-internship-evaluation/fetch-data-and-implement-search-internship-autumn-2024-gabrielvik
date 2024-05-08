using Microsoft.EntityFrameworkCore;
using Web.Backend.Models;

namespace Web.Backend.Data
{
    public class AssignmentContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<User> Users { get; set; }

        public AssignmentContext(DbContextOptions<AssignmentContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection string here
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AssignmentDB");
        }
    }
}