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
using Songkick.Business.Phone.Contracts;
using WG.Network.Phone.Query;
using Songkick.Client.Phone.Contracts;
using Songkick.Client.Phone.Services;
using Songkick.Entities.Phone.General;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WG.Tools.Phone.Helpers;

namespace Songkick.Business.Phone.Services
{
    public class CalendarsBusinessService : ICalendarsBusinessService
    {
        private ICalendarsClientService _calendarsClientService;

        public CalendarsBusinessService(ICalendarsClientService calendarClientService)
        {
            _calendarsClientService = calendarClientService;
        }

        public ObservableCollection<WGGrouping<DateTimeOffset, CalendarEntry>> GetTrackedArtistsCalendar(string username)
        {
            var a =  _calendarsClientService
                .GetTrackedArtistsCalendar(username)
                .ResultsPage
                .Results
                .CalendarEntries
                .GroupBy(entry =>
                    entry.Event.DateOffset)
                .Select(group => group = new WGGrouping<DateTimeOffset, CalendarEntry>(group));
            var b = from objects in a select new WGGrouping<DateTimeOffset, CalendarEntry>(objects);
            return new ObservableCollection<WGGrouping<DateTimeOffset, CalendarEntry>>(b);        
        }

        public ObservableCollection<WGGrouping<DateTimeOffset,CalendarEntry>> GetAttendedCalendar(string username)
        {
            var a = _calendarsClientService
                .GetAttendedCalendar(username)
                .ResultsPage
                .Results
                .CalendarEntries
                .GroupBy(entry => 
                    entry.Event.DateOffset);
            var b = from objects in a select new WGGrouping<DateTimeOffset, CalendarEntry>(objects);

            return new ObservableCollection<WGGrouping<DateTimeOffset, CalendarEntry>>(b);
                
        }
    }
}
