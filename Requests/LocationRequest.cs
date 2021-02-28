using Newtonsoft.Json;
using TGTG.Api.Core.Common;

namespace TGTG.Api.Core.Requests
{
    internal class LocationRequest
    {
        [JsonProperty("query")]
        internal string Query { get; set; }

        [JsonProperty("location")]
        internal BaseCoordinates Coordinates { get; set; }

        public LocationRequest(string query)
        {
            Query = query;
        }
    }
}