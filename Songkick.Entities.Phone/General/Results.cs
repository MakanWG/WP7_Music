﻿using Newtonsoft.Json;
using Songkick.Entities.Phone.Events;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Songkick.Entities.Phone.Venues;

namespace Songkick.Entities.Phone.General
{
    public class Results
    {
        [JsonProperty("event")]
        public ObservableCollection<Event> Events { get; set; }

        [JsonProperty("venue")]
        public ObservableCollection<Venue> Venues { get; set; }

        [JsonProperty("calendarEntry")]
        public ObservableCollection<CalendarEntry> CalendarEntries { get; set; }

        [JsonProperty("artist")]
        public Artist[] Artists { get; set; }

        [JsonProperty("metroArea")]
        public Zone[] MetroAreas { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("totalEntries")]
        public int TotalEntries { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
