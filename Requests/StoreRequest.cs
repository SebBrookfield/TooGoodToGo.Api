using Newtonsoft.Json;
using TGTG.Api.Core.Common;

namespace TGTG.Api.Core.Requests
{
    internal class StoreRequest
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("origin")]
        public BaseCoordinates BaseCoordinates { get; set; }
        [JsonProperty("radius")]
        public double Radius { get; set; }
    }
}