using Microsoft.EntityFrameworkCore;
using Ug.BalanzaDigital.Data.Entities;

namespace Ug.BalanzaDigital.Data.DbContexts;

public class BalanzaDigitalMySqlContext(DbContextOptions<BalanzaDigitalMySqlContext> options)
    : DbContext(options)
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<MaterialReciclado> MaterialesReciclados { get; set; }
    public DbSet<Tamanio> Tamanios { get; set; }
    public DbSet<TipoMaterial> TiposMateriales { get; set; }
    public DbSet<Registros> Registros { get; set; }


    //hacer que al iniciar la base de datos se creen los roles, tipos de materiales y tamaños
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Rol>().HasData(
            new Rol { Id = 1, Nombre = "Admin" },
            new Rol { Id = 2, Nombre = "Gestor" }
        );

        modelBuilder.Entity<TipoMaterial>().HasData(
            new TipoMaterial { Id = 1, Nombre = "Plástico" },
            new TipoMaterial { Id = 2, Nombre = "Vidrio" },
            new TipoMaterial { Id = 3, Nombre = "Metal" },
            new TipoMaterial { Id = 4, Nombre = "Papel" },
            new TipoMaterial { Id = 5, Nombre = "Otro" }
        );

        modelBuilder.Entity<Usuario>().HasData(
            new Usuario
            {
                Id = 1, Username = "admin", Password = "admin123", RolId = 1, Email = "admin@example.com",
                FechaRegistro = DateTime.Now
            },
            new Usuario
            {
                Id = 2, Username = "gestor", Password = "gestor123", RolId = 2, Email = "gestor@example.com",
                FechaRegistro = DateTime.Now
            }
        );

        modelBuilder.Entity<Tamanio>().HasData(
            new Tamanio { Id = 1, Nombre = "Pequeño", RangoAlturaAnchura = "0-10 cm alto y 0-10 cm ancho" },
            new Tamanio { Id = 2, Nombre = "Mediano", RangoAlturaAnchura = "10-20 cm alto y 10-20 cm ancho" },
            new Tamanio { Id = 3, Nombre = "Grande", RangoAlturaAnchura = "20+ cm alto y 20+ cm ancho" }
        );

        modelBuilder.Entity<MaterialReciclado>()
            .HasOne(m => m.Tipo)
            .WithMany(t => t.MaterialesReciclados)
            .HasForeignKey(m => m.TipoId);

        modelBuilder.Entity<MaterialReciclado>()
            .HasOne(m => m.Tamanio)
            .WithMany(t => t.MaterialesReciclados)
            .HasForeignKey(m => m.TamanioId);

        modelBuilder.Entity<Registros>()
            .Property(r => r.ProcesadoEnAppWeb)
            .HasDefaultValue(false);
    }
}