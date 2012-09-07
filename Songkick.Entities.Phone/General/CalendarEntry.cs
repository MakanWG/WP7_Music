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
using Songkick.Entities.Phone.Events;

namespace Songkick.Entities.Phone.General
{
    public class CalendarEntry
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("event")]
        public Event Event { get; set; }

        [JsonProperty("reason")]
        public Reason Reason { get; set; }
    }
}
