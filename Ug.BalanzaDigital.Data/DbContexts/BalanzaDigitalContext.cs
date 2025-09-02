using Microsoft.EntityFrameworkCore;
using Ug.BalanzaDigital.Data.Entities;

namespace Ug.BalanzaDigital.Data.DbContexts;

// public class BalanzaDigitalContext: DbContext
public class BalanzaDigitalContext(DbContextOptions<BalanzaDigitalContext> options)
    : DbContext(options)
{
    public DbSet<Usuario> Usuarios { get; set; }
}