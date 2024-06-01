using ConsoleApp1.Entity;
using Microsoft.EntityFrameworkCore;

public class OkulContext : DbContext
{
    public DbSet<Ders> Dersler { get; set; }
    public DbSet<DersProgrami> DersProgramlari { get; set; }
    public DbSet<Mudur> Mudurler { get; set; }
    public DbSet<Not> Notlar { get; set; }
    public DbSet<Ogrenci> Ogrenciler { get; set; }
    public DbSet<Ogretmen> Ogretmenler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=deneme;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Ders ve DersProgrami arasındaki ilişki
        modelBuilder.Entity<Ders>()
            .HasMany(d => d.DersProgramlari)
            .WithOne(dp => dp.Ders)
            .HasForeignKey(dp => dp.DersId);

        // Ders ve Notlar arasındaki ilişki
        modelBuilder.Entity<Ders>()
            .HasMany(d => d.Notlar)
            .WithOne(n => n.Ders)
            .HasForeignKey(n => n.DersId);

        // DersProgrami ve Ogretmenler arasındaki ilişki
        modelBuilder.Entity<DersProgrami>()
            .HasMany(dp => dp.Ogretmenler)
            .WithMany(o => o.DersProgramlari);

        // Notlar ve Ogrenci arasındaki ilişki
        modelBuilder.Entity<Not>()
            .HasOne(n => n.Ogrenci)
            .WithMany(o => o.Notlar)
            .HasForeignKey(n => n.OgrenciId);

        // OgrenciDersProgrami ara tablosu ilişkileri
        modelBuilder.Entity<OgrenciDersProgrami>()
            .HasKey(odp => new { odp.OgrenciId, odp.DersProgramiId });

        modelBuilder.Entity<OgrenciDersProgrami>()
            .HasOne(odp => odp.Ogrenci)
            .WithMany(o => o.OgrenciDersProgramlari)
            .HasForeignKey(odp => odp.OgrenciId);

        modelBuilder.Entity<OgrenciDersProgrami>()
            .HasOne(odp => odp.DersProgrami)
            .WithMany(dp => dp.OgrenciDersProgramlari)
            .HasForeignKey(odp => odp.DersProgramiId);
    }


}