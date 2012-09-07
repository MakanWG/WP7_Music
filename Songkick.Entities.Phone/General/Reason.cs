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

namespace Songkick.Entities.Phone.General
{
    public class Reason
    {
        [JsonProperty("attendance")]
        public string Attendance { get; set; }

        [JsonProperty("trackedArtist")]
        public Artist TrackedArtist { get; set; }
    }
}
