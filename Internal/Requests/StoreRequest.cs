using Newtonsoft.Json;
using TGTG.Api.Core.Internal.Common;

namespace TGTG.Api.Core.Internal.Requests
{
    internal class StoreRequest
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("origin")]
        internal LocationCoordinates LocationCoordinates { get; set; }
        [JsonProperty("radius")]
        internal double Radius { get; set; }
    }
}