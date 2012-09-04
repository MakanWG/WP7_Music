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
    public class Performance
    {
        [JsonProperty("artist")]
        public IEnumerable<Artist> Artists { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("billingIndex")]
        public int BillingIndex { get; set; }

        [JsonProperty("id")]
        public long PerformanceId { get; set; }

        [JsonProperty("billing")]
        public string Billing { get; set; }
    }
}
