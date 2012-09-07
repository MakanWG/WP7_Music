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

namespace Songkick.Business.Phone.Services
{
    public class CalendarsBusinessService : ICalendarsBusinessService
    {
        public ICalendarsClientService CalendarsClientService { get; set; }

        public CalendarsBusinessService()
        {
            CalendarsClientService = new CalendarsClientService();
        }
        public void GetTrackedArtistsCalendar(string username, Action<EntityWrapper> callback)
        {
            CalendarsClientService.GetTrackedArtistsCalendar(username, callback);
        }

        public void GetAttendedCalendar(string username, Action<EntityWrapper> callback)
        {
            CalendarsClientService.GetAttendedCalendar(username, callback);
        }
    }
}
