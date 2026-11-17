using Microsoft.EntityFrameworkCore;

namespace Billetsystem_Backend.Data;

public class BilletDbContext : DbContext
{
    public BilletDbContext(DbContextOptions<BilletDbContext> options)
        : base(options) {}
    
    
}