using System.Collections.Generic;
using Newtonsoft.Json;
using TGTG.Api.Core.Internal.Common;

namespace TGTG.Api.Core.Internal.Responses
{
    internal class StoreResponse
    {
        [JsonProperty("items")]
        internal List<StoreContainer> Containers { get; set; }
    }

    internal class StoreContainer
    {
        [JsonProperty("item")]
        internal Item Item { get; set; }

        [JsonProperty("store")]
        internal StoreItem Store { get; set; }

        [JsonProperty("pickup_location")]
        internal StoreItemAddress PickupLocation { get; set; }

        [JsonProperty("favorite")]
        internal bool Favorited { get; set; }

        [JsonProperty("distance")]
        internal double Distance { get; set; }

        [JsonProperty("items_available")]
        internal int ItemsAvailable { get; set; }

        [JsonProperty("in_sales_window")]
        internal bool InSalesWindow { get; set; }
    }

    internal class Item
    {
        [JsonProperty("item_id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    internal class StoreItem
    {
        [JsonProperty("store_id")]
        public string Id { get; set; }

        [JsonProperty("store_name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    internal class StoreItemAddress
    {
        [JsonProperty("address")]
        internal ItemAddress Address { get; set; }
        
        [JsonProperty("location")]
        internal LocationCoordinates LocationCoordinates { get; set; }
    }

    internal class ItemAddress
    {
        [JsonProperty("country")]
        internal Country Country { get; set; }
        [JsonProperty("address_line")]
        public string AddressLine { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("postal_code")]
        public string Postcode { get; set; }
    }

    internal class Country
    {
        [JsonProperty("country")]
        public string Name { get; set; }
    }
}