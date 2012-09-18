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
using WG.Network.Phone.Query;
using Newtonsoft.Json;

namespace Songkick.Entities.Phone.General
{
    public class Response
    {
        [JsonProperty("resultsPage")]
        public ResultsPage ResultsPage { get; set; }
    }
}
