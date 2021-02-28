namespace TGTG.Api.Core
{
    internal static class Urls
    {
        internal static string Login() => "auth/v2/loginByEmail";
        internal static string Refresh() => "auth/v2/token/refresh";
        internal static string Stores() => "item/v7/";
        internal static string Locations() => "location/v1/search";
    }
}