using System.ComponentModel.DataAnnotations;
namespace GeoSnowAPI.Entities
{
    public class Resort
    {
        public int ResortID { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string ResortType { get; set; }
        public string Email { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
