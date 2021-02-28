using Newtonsoft.Json;

namespace TGTG.Api.Core.Requests
{
    public class LoginRequest
    {
        [JsonProperty("device_type")]
        public string DeviceType => "ANDROID";
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }

        public LoginRequest(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}