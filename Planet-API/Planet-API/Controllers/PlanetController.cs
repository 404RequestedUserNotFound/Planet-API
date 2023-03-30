using Planet_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Planet_API.Controllers
{
    public class PlanetController : ApiController
    {
        [HttpGet]
        [Route("api/planet/all")]

        public List<Planet> GetAllPlanets()
        {
            List<Planet> planets = new List<Planet>();
            planets.Add(new Planet()
            {
                PlanetId = 1,
                Name = "Mercury",
                Description = "Mercury is the smallest planet in our solar system and the closest to the Sun.",
                ImageUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2437_PIA00069.jpg",
                DistanceFromSun = 57910000,
                Diameter = 4879,
                Mass = 3.285e23,
                NumberOfMoons = 0,
                LengthOfDay = 4222.6,
                LengthOfYear = 88,
                AverageTemperature = 167
            });

            planets.Add(new Planet()
            {
                PlanetId = 2,
                Name = "Venus",
                Description = "Venus is the second planet from the Sun. It is named after the Roman goddess of love and beauty.",
                ImageUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2438_PIA00070.jpg",
                DistanceFromSun = 108200000,
                Diameter = 12104,
                Mass = 4.867e24,
                NumberOfMoons = 0,
                LengthOfDay = 2802,
                LengthOfYear = 225,
                AverageTemperature = 464
            });

            planets.Add(new Planet()
            {
                PlanetId = 3,
                Name = "Earth",
                Description = "Earth is the third planet from the Sun and the only astronomical object known to harbor life.",
                ImageUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2436_PIA00068.jpg",
                DistanceFromSun = 149600000,
                Diameter = 12756,
                Mass = 5.972e24,
                NumberOfMoons = 1,
                LengthOfDay = 24,
                LengthOfYear = 365.25,
                AverageTemperature = 15
            });
            
            planets.Add(new Planet()
            {
                PlanetId = 4,
                Name = "Mars",
                Description = "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System, being only larger than Mercury.",
                ImageUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2439_PIA00071.jpg",
                DistanceFromSun = 227900000,
                Diameter = 6792,
                Mass = 6.39e23,
                NumberOfMoons = 2,
                LengthOfDay = 24.7,
                LengthOfYear = 687,
                AverageTemperature = -65
            });


            planets.Add(new Planet()
            {
                PlanetId = 5,
                Name = "Jupiter",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System.",
                ImageUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2440_PIA00072.jpg",
                DistanceFromSun = 778300000,
                Diameter = 142984,
                Mass = 1.898e27,
                NumberOfMoons = 67,
                LengthOfDay = 9.9,
                LengthOfYear = 4331,
                AverageTemperature = -110
            });
            return planets;
             
        }


        [HttpGet]
        [Route("api/planet/name")]
        public List<string>GetPlanetsID ()
        {
            var planets = new List<Planet>();
            {
                planets.Add(new Planet()
                {
                    PlanetId = 1,
                    Name = "Mercury",
                    Description = "Mercury is the smallest planet in our solar system and the closest to the Sun.",
                    ImageUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2437_PIA00069.jpg",
                    DistanceFromSun = 57910000,
                    Diameter = 4879,
                    Mass = 3.285e23,
                    NumberOfMoons = 0,
                    LengthOfDay = 4222.6,
                    LengthOfYear = 88,
                    AverageTemperature = 167
                });

                planets.Add(new Planet()
                {
                    PlanetId = 2,
                    Name = "Venus",
                    Description = "Venus is the second planet from the Sun. It is named after the Roman goddess of love and beauty.",
                    ImageUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2438_PIA00070.jpg",
                    DistanceFromSun = 108200000,
                    Diameter = 12104,
                    Mass = 4.867e24,
                    NumberOfMoons = 0,
                    LengthOfDay = 2802,
                    LengthOfYear = 225,
                    AverageTemperature = 464
                });

                planets.Add(new Planet()
                {
                    PlanetId = 3,
                    Name = "Earth",
                    Description = "Earth is the third planet from the Sun and the only astronomical object known to harbor life.",
                    ImageUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2436_PIA00068.jpg",
                    DistanceFromSun = 149600000,
                    Diameter = 12756,
                    Mass = 5.972e24,
                    NumberOfMoons = 1,
                    LengthOfDay = 24,
                    LengthOfYear = 365.25,
                    AverageTemperature = 15
                });

                planets.Add(new Planet()
                {
                    PlanetId = 4,
                    Name = "Mars",
                    Description = "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System, being only larger than Mercury.",
                    ImageUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2439_PIA00071.jpg",
                    DistanceFromSun = 227900000,
                    Diameter = 6792,
                    Mass = 6.39e23,
                    NumberOfMoons = 2,
                    LengthOfDay = 24.7,
                    LengthOfYear = 687,
                    AverageTemperature = -65
                });

                planets.Add(new Planet()
                {
                    PlanetId = 5,
                    Name = "Jupiter",
                    Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System.",
                    ImageUrl = "https://solarsystem.nasa.gov/system/resources/detail_files/2440_PIA00072.jpg",
                    DistanceFromSun = 778300000,
                    Diameter = 142984,
                    Mass = 1.898e27,
                    NumberOfMoons = 67,
                    LengthOfDay = 9.9,
                    LengthOfYear = 4331,
                    AverageTemperature = -110
                });
            }


            var names = (from i in planets
                            select i.Name).ToList();
            return names;
        }
        
    }
}
