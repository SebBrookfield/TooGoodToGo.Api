using Newtonsoft.Json;

namespace TGTG.Api.Core.Common
{
    internal class BaseCoordinates
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        public BaseCoordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public BaseCoordinates()
        {
        }
    }
}