namespace FinalProjectExample;

internal static class SteamUrlUtility
{
    public const string CallbackSuffix = "auth/steam/callback";

    public static (string Realm, string Callback) ConstructUrls(Uri uri, string callbackSuffix = CallbackSuffix)
    {
        string realm = uri.GetComponents(UriComponents.SchemeAndServer, UriFormat.UriEscaped);
        string callback = realm.EndsWith('/') ? realm + callbackSuffix : realm + "/" + callbackSuffix;
        return (realm, callback);
    }
}
