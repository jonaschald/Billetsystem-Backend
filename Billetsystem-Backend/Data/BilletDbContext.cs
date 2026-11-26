using Billetsystem_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Billetsystem_Backend.Data;

public class BilletDbContext : DbContext
{
    public BilletDbContext(DbContextOptions<BilletDbContext> options)
        : base(options) {}
    
    public DbSet<Forestillinger> Forestillinger => Set<Forestillinger>();
    public DbSet<Teatersal> Teatersale => Set<Teatersal>();
}