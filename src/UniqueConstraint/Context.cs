using Microsoft.EntityFrameworkCore;
using UniqueConstraint.Models;

namespace UniqueConstraint
{
    public class Context : DbContext
    {
        protected DbSet<Model> Models { get; set; }
        protected DbSet<Relation> Relations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Relation>().HasIndex(prop => prop.Title).IsUnique(true);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=UniqueConstraintDatabase;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
    }
}
