using Newtonsoft.Json;
using System.Collections.Generic;

namespace Songkick.Entities.Phone.Events
{
    public class Performance
    {
       /* [JsonProperty("artist")]
        public Artist[] Artists { get; set; }*/

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
