namespace TGTG.Api.Core.Models
{
    public class Address
    {
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public Coordinates GeoLocation { get; set; }
    }
}