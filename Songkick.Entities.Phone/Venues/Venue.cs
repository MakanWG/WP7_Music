using Newtonsoft.Json;

namespace Songkick.Entities.Phone.Venues
{
    public class Venue
    {
        [JsonProperty("id")]
        public long VenueId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("city")]
        public Zone City { get; set; }

        [JsonProperty("metroArea")]
        public Zone MetroArea { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("lat")]
        public long Latitude { get; set; }

        [JsonProperty("lng")]
        public long Longitude { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
