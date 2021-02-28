using System.Collections.Generic;
using Newtonsoft.Json;
using TGTG.Api.Core.Common;

namespace TGTG.Api.Core.Responses
{
    internal class StoreResponse
    {
        [JsonProperty("items")]
        public List<StoreContainer> Containers { get; set; }
    }

    internal class StoreContainer
    {
        [JsonProperty("item")]
        internal Item Item { get; set; }

        [JsonProperty("store")]
        internal StoreItem Store { get; set; }

        [JsonProperty("pickup_location")]
        public StoreItemAddress PickupLocation { get; set; }

        [JsonProperty("favorite")]
        public bool Favorited { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }
    }

    internal class Item
    {
        [JsonProperty("item_id")]
        internal string Id { get; set; }

        [JsonProperty("description")]
        internal string Description { get; set; }
    }

    internal class StoreItem
    {
        [JsonProperty("store_id")]
        internal string Id { get; set; }

        [JsonProperty("store_name")]
        internal string Name { get; set; }

        [JsonProperty("website")]
        internal string Website { get; set; }
    }

    internal class StoreItemAddress
    {
        [JsonProperty("address")]
        internal ItemAddress Address { get; set; }
        
        [JsonProperty("location")]
        internal BaseCoordinates BaseCoordinates { get; set; }
    }

    internal class ItemAddress
    {
        [JsonProperty("country")]
        internal Country Country { get; set; }
        [JsonProperty("address_line")]
        internal string AddressLine { get; set; }
        [JsonProperty("city")]
        internal string City { get; set; }
        [JsonProperty("postal_code")]
        internal string Postcode { get; set; }
    }

    internal class Country
    {
        [JsonProperty("country")]
        internal string Name { get; set; }
    }
}