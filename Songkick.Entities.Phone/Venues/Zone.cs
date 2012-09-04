using Newtonsoft.Json;

namespace Songkick.Entities.Phone.Venues
{
    public class Zone
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("id")]
        public long ZoneId { get; set; }
    }
}
