using Newtonsoft.Json;

namespace Songkick.Entities.Phone.Events
{
    public class Venue
    {
        [JsonProperty("lng")]
        public long? Longitude { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("lat")]
        public long? Latitude { get; set; }

        [JsonProperty("id")]
        public long IdVenue { get; set; }
    }
}
