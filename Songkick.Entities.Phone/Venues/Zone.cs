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

namespace Songkick.Entities.Phone.Venues
{
    public class Zone
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("id")]
        public long ZoneId { get; set; }
    }
}
