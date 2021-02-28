using Newtonsoft.Json;

namespace TGTG.Api.Core.Internal.Common
{
    internal class LocationCoordinates
    {
        [JsonProperty("latitude")]
        internal double Latitude { get; set; }

        [JsonProperty("longitude")]
        internal double Longitude { get; set; }

        internal LocationCoordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        internal LocationCoordinates()
        {
        }
    }
}