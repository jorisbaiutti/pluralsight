using System.Collections.Generic;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big Park",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Most visited Urban Park in the United States"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Old Skyscraper"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Bern",
                    Description = "Hauptstadt",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Münster",
                            Description = "Old Church"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Luna Lena",
                            Description = "Bar in Breitenrain"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Wabern",
                    Description = "Standort Rotes Kreuz Schweiz",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "SRK",
                            Description = "Rotes Kreuz Schweiz"
                        }
                    }
                }
            };
        }
    }
}