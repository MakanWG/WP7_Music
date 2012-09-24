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
using Songkick.Entities.Phone.Events;

namespace Songkick.Business.Phone.ExtendedEntities
{
    public class EventEx : Event
    {
        public EventEx()
        {
            
        }
        public EventEx(Event skEvent)
        {
            this.DisplayName = skEvent.DisplayName;
            this.EventId = skEvent.EventId;
            this.EventStart = skEvent.EventStart;
            this.Performance = skEvent.Performance;
            this.EventLocation = skEvent.EventLocation;
            this.Poularity = skEvent.Poularity;
            this.Status = skEvent.Status;
            this.Type = skEvent.Type;
            this.Uri = skEvent.Uri;
            this.Venue = skEvent.Venue;
            this.DateOffset = DateTimeOffset.Parse(EventStart.Date);
            this.FullVenueName = string.Format("{0}, {1}", Venue.DisplayName, EventLocation.City);
        }

        public DateTimeOffset DateOffset { get; set; }

        public string FullVenueName { get; set; }
    }
}
