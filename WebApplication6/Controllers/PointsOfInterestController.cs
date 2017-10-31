using System;
using System.Collections.Generic;
using Business.Repositories;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    public class PointsOfInterestController : Controller
    {
        private readonly IPointOfInterestRepository _repository;

        public PointsOfInterestController(IPointOfInterestRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<PointOfInterest> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public PointOfInterest Get(Guid id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]CreatePointOfInterestModel pointOfInterest)
        {
            var entity = PointOfInterest.Create(pointOfInterest.Address, pointOfInterest.Description, pointOfInterest.IsComplete);
            _repository.Add(entity);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]UpdatePointOfInterestModel pointOfInterest)
        {
            var entity = _repository.GetById(id);
            entity.Update(pointOfInterest.Address, pointOfInterest.Description, pointOfInterest.IsComplete);
            // magic
            _repository.Edit(entity);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
