using Newtonsoft.Json;
using Songkick.Entities.Phone.Events;
using System.Collections.Generic;

namespace Songkick.Entities.Phone.General
{
    public class Results
    {
        [JsonProperty("event")]
        public IEnumerable<Event> Events { get; set; }

        [JsonProperty("venue")]
        public Venues.Venue Venue { get; set; }
    }
}
