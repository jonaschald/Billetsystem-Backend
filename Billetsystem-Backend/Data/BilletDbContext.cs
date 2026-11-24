using Billetsystem_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Billetsystem_Backend.Data;

public class BilletDbContext : DbContext
{
    public BilletDbContext(DbContextOptions<BilletDbContext> options)
        : base(options) {}

    public DbSet<Bruger> Brugere { get; set; }
    public DbSet<Rolle> Roller { get; set; }
    public DbSet<Teatersal> Teatersale { get; set; }
    public DbSet<Priskategori> Priskategorier { get; set; }
    public DbSet<BilletType> BilletTyper { get; set; }
    public DbSet<Kunde> Kunder { get; set; }
    public DbSet<Forestilling> Forestillinger { get; set; }
    public DbSet<Opfoerelse> Opfoerelser { get; set; }
    public DbSet<Bestilling> Bestillinger { get; set; }
    public DbSet<Billet> Billeter { get; set; }
    public DbSet<Plads> Pladser { get; set; }
}