using Api.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Database;

public class FreyaContext : DbContext
{
    public FreyaContext(DbContextOptions<FreyaContext> options)
    : base(options)
    {
    }

    public DbSet<Reservation> Reservations { get; set; }
}
