using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
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
        public IEnumerable<Performance> Performance { get; set; }

        [JsonProperty("id")]
        public long EventId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("popularity")]
        public decimal Poularity { get; set; }
    }
}
