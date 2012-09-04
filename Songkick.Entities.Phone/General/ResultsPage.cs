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
