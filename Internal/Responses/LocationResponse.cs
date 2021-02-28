using System.Collections.Generic;
using Newtonsoft.Json;
using TGTG.Api.Core.Internal.Common;

namespace TGTG.Api.Core.Internal.Responses
{
    internal class LocationResponse
    {
        [JsonProperty("locations")]
        internal List<LocationResult> Locations { get; set; }
    }

    internal class LocationResult
    {
        [JsonProperty("display_name")]
        public string Name { get; set; }

        [JsonProperty("center")]
        internal LocationCoordinates Coordinates { get; set; }
    }
}