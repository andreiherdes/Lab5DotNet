using System;
using System.Collections.Generic;
using Data.Entities;

namespace Business.Repositories
{
    public interface IPointOfInterestRepository
    {
        IReadOnlyList<PointOfInterest> GetAll();

        PointOfInterest GetById(Guid id);

        void Add(PointOfInterest pointOfInterest);

        void Edit(PointOfInterest pointOfInterest);

        void Delete(Guid id);
    }
}