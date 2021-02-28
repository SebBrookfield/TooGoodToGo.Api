namespace TGTG.Api.Core.Internal.Common
{
    internal static class Urls
    {
        internal const string Login = "auth/v2/loginByEmail";
        internal const string Refresh = "auth/v2/token/refresh";
        internal const string Stores = "item/v7/";
        internal const string Locations = "location/v1/search";
        internal static string SetFavourite(string itemId) => $"item/v7/{itemId}/setFavorite";
    }
}