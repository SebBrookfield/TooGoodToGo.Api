using Newtonsoft.Json;

namespace TGTG.Api.Core.Internal.Requests
{
    public class FavouriteRequest
    {
        [JsonProperty("is_favorite")]
        public bool IsFavourite { get; set; }

        public static implicit operator FavouriteRequest(bool isFavourite) => new FavouriteRequest { IsFavourite = isFavourite }
    }
}