using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public interface IDatabaseService
    {
        DbSet<PointOfInterest> PointsOfInterest { get; set; }

        int SaveChanges();
    }
}