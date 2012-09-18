﻿using Newtonsoft.Json;
using Songkick.Entities.Phone.Events;
using System.Collections.Generic;

namespace Songkick.Entities.Phone.General
{
    public class Results
    {
        [JsonProperty("event")]
        public Event[] Events { get; set; }

        [JsonProperty("venue")]
        public Venues.Venue Venue { get; set; }

        [JsonProperty("calendarEntry")]
        public CalendarEntry[] CalendarEntries { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("totalEntries")]
        public int TotalEntries { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
