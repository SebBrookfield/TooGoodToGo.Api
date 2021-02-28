using Newtonsoft.Json;
using TGTG.Api.Core.Internal.Common;

namespace TGTG.Api.Core.Internal.Requests
{
    internal class LocationRequest
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("location")]
        internal LocationCoordinates Coordinates { get; set; }

        internal LocationRequest(string query)
        {
            Query = query;
        }
    }
}