using Microsoft.EntityFrameworkCore;

namespace EF.Demo.SqlProvider;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public virtual DbSet<SomeDbModel> MyModels { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SomeDbModel>(entity =>
        {
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });
    }
}