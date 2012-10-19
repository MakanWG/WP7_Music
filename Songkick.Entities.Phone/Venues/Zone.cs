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

        [JsonProperty("lat")]
        public double? Latitude { get; set; }

        [JsonProperty("lng")]
        public double? Longitude { get; set; }

        [JsonProperty("state")]
        public State State { get; set; }
    }
}
