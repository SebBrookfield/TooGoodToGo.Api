using Newtonsoft.Json;

namespace TGTG.Api.Core.Responses
{
    public class LoginResponse : TokenResponse
    {
        [JsonProperty("startup_data")]
        public StartupData Data { get; set; }
    }

    public class StartupData
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class User
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("country_id")]
        public string CountryId { get; set; }
        
        [JsonProperty("email")]
        public string Email { get; set; }
        
        [JsonProperty("phone_country_code")]
        public string PhoneCountryCode { get; set; }
        
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        
        [JsonProperty("role")]
        public string Role { get; set; }
        
        [JsonProperty("is_partner")]
        public bool IsPartner { get; set; }
        
        [JsonProperty("newsletter_opt_in")]
        public bool NewsletterOptIn { get; set; }
        
        [JsonProperty("push_notifications_opt_in")]
        public bool PushNotificationsOptIn { get; set; }
    }
}