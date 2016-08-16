namespace Destiny.Client
{
    public class DestinyClientConfiguration
    {
        public DestinyClientConfiguration()
        {
            baseUrl = "https://www.bungie.net/Platform/Destiny/";
        }
        public string apiKey { get; set; }
        public string baseUrl { get; set; }
    }
}
