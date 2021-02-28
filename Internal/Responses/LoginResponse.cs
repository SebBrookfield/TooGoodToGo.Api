using Newtonsoft.Json;

namespace TGTG.Api.Core.Internal.Responses
{
    internal class LoginResponse : TokenResponse
    {
        [JsonProperty("startup_data")]
        internal StartupData Data { get; set; }
    }

    internal class StartupData
    {
        [JsonProperty("user")]
        internal User User { get; set; }
    }

    internal class User
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
        internal bool IsPartner { get; set; }

        [JsonProperty("newsletter_opt_in")]
        internal bool NewsletterOptIn { get; set; }

        [JsonProperty("push_notifications_opt_in")]
        internal bool PushNotificationsOptIn { get; set; }
    }
}