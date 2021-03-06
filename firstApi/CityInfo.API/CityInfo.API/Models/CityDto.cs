using System.Collections;
using System.Collections.Generic;

namespace CityInfo.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPointsOfInterest { get; set; }

        public List<PointOfInterestDto> PointOfInterest { get; set; } = new List<PointOfInterestDto>();
    }
}