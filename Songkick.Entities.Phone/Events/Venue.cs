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

namespace Songkick.Entities.Phone.Events
{
    public class Venue
    {
        [JsonProperty("lng")]
        public long Longitude { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("lat")]
        public long Latitude { get; set; }

        [JsonProperty("id")]
        public long IdVenue { get; set; }
    }
}
