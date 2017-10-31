using System;
using System.Collections.Generic;
using System.Linq;
using Data.Context;
using Data.Entities;

namespace Business.Repositories
{
    public class PointOfInterestRepository : IPointOfInterestRepository
    {
        private readonly IDatabaseService _databaseService;

        public PointOfInterestRepository(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public IReadOnlyList<PointOfInterest> GetAll()
        {
            return _databaseService.PointsOfInterest.ToList();
        }

        public PointOfInterest GetById(Guid id)
        {
            return _databaseService.PointsOfInterest.FirstOrDefault(t => t.Id == id);
        }

        public void Add(PointOfInterest pointOfInterest)
        {
            _databaseService.PointsOfInterest.Add(pointOfInterest);
            _databaseService.SaveChanges();
        }

        public void Edit(PointOfInterest pointOfInterest)
        {
            _databaseService.PointsOfInterest.Update(pointOfInterest);
            _databaseService.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var pointOfInterest = GetById(id);
            _databaseService.PointsOfInterest.Remove(pointOfInterest);
            _databaseService.SaveChanges();
        }
    }
}
