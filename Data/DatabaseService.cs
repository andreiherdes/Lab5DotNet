using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DatabaseService(DbContextOptions<DatabaseService> options) : base(options)
        {
        }

        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
    }
}
