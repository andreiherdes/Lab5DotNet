using System;

namespace Data.Entities
{
    public class PointOfInterest
    {
        private PointOfInterest()
        {
            // EF Core
        }

        public Guid Id { get; private set; }

        public string Address { get; private set; }

        public string Description { get; private set; }

        public bool IsComplete { get; private set; }

        public static PointOfInterest Create(string address, string description, bool isComplete)
        {
            var instance = new PointOfInterest { Id = Guid.NewGuid() };
            instance.Update(address, description, isComplete);
            return instance;
        }

        public void Update(string address, string description, bool isComplete)
        {
            Address = address;
            Description = description;
            IsComplete = isComplete;
        }
    }
}
