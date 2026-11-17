using Microsoft.EntityFrameworkCore;

public class Mua_Mí_Sính_Buổi_6Context(DbContextOptions<Mua_Mí_Sính_Buổi_6Context> options) : DbContext(options)
{
    public DbSet<Mua_Mí_Sính_Buổi_6.Models.Genre> Genre { get; set; } = default!;
    public DbSet<Mua_Mí_Sính_Buổi_6.Models.Movie> Movies { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Mua_Mí_Sính_Buổi_6.Models.Movie>()
            .HasOne(m => m.Genre)
            .WithMany(g => g.Movie)
            .HasForeignKey(m => m.GenreID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}