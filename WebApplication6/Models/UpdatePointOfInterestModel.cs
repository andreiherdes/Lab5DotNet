using System;

namespace WebApp.Models
{
    public class UpdatePointOfInterestModel
    {
        public Guid Id { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public bool IsComplete { get; set; }
    }
}
