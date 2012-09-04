using Newtonsoft.Json;
using WG.Network.Phone.Query;

namespace Songkick.Entities.Phone.General
{
    public class ResultsPage : EntityWrapper
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("totalEntries")]
        public int TotalEntries { get; set; }

        [JsonProperty("perPage")]
        public int PerPage { get; set; }

        [JsonProperty("results")]
        public Results Results { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
