using Newtonsoft.Json;

namespace Songkick.Entities.Phone.Events
{
    public class EventStart
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("datetime")]
        public string DateTime { get; set; }
    }
}
