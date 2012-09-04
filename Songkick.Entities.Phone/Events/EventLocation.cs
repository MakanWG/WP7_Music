using Newtonsoft.Json;

namespace Songkick.Entities.Phone.Events
{
    public class EventLocation
    {
        [JsonProperty("lng")]
        public long Longitude { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("lat")]
        public long Latitude { get; set; }
    }
}
