using System.Collections.Generic;
using System.Linq;
using CityInfo.API.Models;

namespace CityInfo.API.Entities
{
    public static class CityInfoContextExtensions 
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any()) return;

            //init data seed
            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with the big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        }
                    }
                },
                new City()
                {
                    Name = "Antwerp",
                    Description = "The one with the cathderal that was never really finished."

                },
                new City()
                {
                    Name = "Paris",
                    Description = "The one with the big tower."

                }
            };
            
            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}