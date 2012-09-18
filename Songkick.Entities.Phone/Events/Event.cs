using Newtonsoft.Json;
using System.Collections.Generic;

namespace Songkick.Entities.Phone.Events
{
    public class Event
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("venue")]
        public Venue Venue { get; set; }

        [JsonProperty("location")]
        public EventLocation EventLocation { get; set; }

        [JsonProperty("start")]
        public EventStart EventStart { get; set; }

        [JsonProperty("performance")]
        public Performance[] Performance { get; set; }

        [JsonProperty("id")]
        public long EventId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("popularity")]
        public decimal Poularity { get; set; }
    }
}
