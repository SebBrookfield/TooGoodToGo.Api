using Newtonsoft.Json;

namespace TGTG.Api.Core.Internal.Requests
{
    internal class RefreshTokenRequest
    {
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        public static implicit operator RefreshTokenRequest(string str) => new RefreshTokenRequest { RefreshToken = str };
    }
}