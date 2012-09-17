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

namespace Songkick.Business.Phone.Services
{
    public class CalendarsBusinessService : ICalendarsBusinessService
    {
        private ICalendarsClientService _calendarsClientService;

        public CalendarsBusinessService(ICalendarsClientService calendarClientService)
        {
            _calendarsClientService = calendarClientService;
        }

        public ResultsPage GetTrackedArtistsCalendar(string username)
        {
           return _calendarsClientService.GetTrackedArtistsCalendar(username);
        }

        public ResultsPage GetAttendedCalendar(string username)
        {
            return _calendarsClientService.GetAttendedCalendar(username);
        }
    }
}
