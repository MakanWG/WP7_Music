using Newtonsoft.Json;

namespace Songkick.Entities.Phone.Events
{
    public class Artist
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public long ArtistId { get; set; }
    }
}
