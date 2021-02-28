using Newtonsoft.Json;

namespace TGTG.Api.Core.Requests
{
    public class RefreshTokenRequest
    {
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        public RefreshTokenRequest(string refreshToken)
        {
            RefreshToken = refreshToken;
        }
    }
}