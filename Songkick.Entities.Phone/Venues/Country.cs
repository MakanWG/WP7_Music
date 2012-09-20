using Newtonsoft.Json;

namespace Songkick.Entities.Phone.Venues
{
    public class Country
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}
