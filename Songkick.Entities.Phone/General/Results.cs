﻿using System;
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
using System.Collections.Generic;

namespace Songkick.Entities.Phone.General
{
    public class Results
    {
        [JsonProperty("event")]
        public IEnumerable<Event> Events { get; set; }

        [JsonProperty("venue")]
        public Venues.Venue Venue { get; set; }
    }
}
