using System.Diagnostics.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ef_issue;

public class DataContext : DbContext
{
    public DbSet<Campaign> Campaigns { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("postgis");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Timeout=25;CommandTimeout=30;Database=db;User Id=db;Pwd=db;", opt => opt.UseNetTopologySuite());
    }
}