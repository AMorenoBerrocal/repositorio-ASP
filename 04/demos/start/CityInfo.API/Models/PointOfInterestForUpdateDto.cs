using System.Security.Cryptography.X509Certificates;

namespace CityInfo.API.Models
{
    public class PointOfInterestForUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
