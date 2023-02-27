using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with the big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the US."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Cathedral of Our Lady",
                            Description = "A gothic style cathedral"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Antwerp Central Station",
                            Description = "The finest exampe of railway architecture in Belgium."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Copenhagen",
                    Description = "The one with the Little Mermaid.",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "The Little Mermaid",
                            Description = "Small bronze statue gazing out to sea has been one of Copenhagen's top tourist attractions."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Tivoli",
                            Description = "Tivoli Gardens, also known simply as Tivoli, is an amusement park and pleasure garden."
                        }
                    }
                }
            };
        }
    }
}
