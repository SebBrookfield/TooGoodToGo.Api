using System.Collections.Generic;
using Newtonsoft.Json;
using TGTG.Api.Core.Common;

namespace TGTG.Api.Core.Responses
{
    internal class LocationResponse
    {
        [JsonProperty("locations")]
        internal List<LocationResult> Locations { get; set; }
    }

    internal class LocationResult
    {
        [JsonProperty("display_name")]
        internal string Name { get; set; }

        [JsonProperty("center")]
        internal BaseCoordinates Coordinates { get; set; }
    }
}