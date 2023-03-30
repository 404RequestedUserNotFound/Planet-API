using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planet_API.Models
{
    public class Planet
    {
        public int PlanetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double DistanceFromSun { get; set; }
        public double Diameter { get; set; }
        public double Mass { get; set; }
        public int NumberOfMoons { get; set; }
        public double LengthOfDay { get; set; }
        public double LengthOfYear { get; set; }
        public double AverageTemperature { get; set; }

    }
}