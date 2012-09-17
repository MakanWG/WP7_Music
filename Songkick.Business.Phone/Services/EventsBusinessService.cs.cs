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
using Songkick.Client.Phone.Contracts;
using Songkick.Client.Phone.Services;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;

namespace Songkick.Business.Phone.Services
{
    public class EventsBusinessService : IEventsBusinessService
    {
        private IEventsClientService _eventsClientService;
        public EventsBusinessService(IEventsClientService eventsClientService)
        {
            _eventsClientService = eventsClientService;
        }

        public ResultsPage SearchEvents(long location, string artistName = "", string minDate = "", string maxDate = "")
        {
            return _eventsClientService.SearchEvents(location, artistName = "", minDate = "", maxDate = "");
        }

        public ResultsPage GetAttendedEvents(string username)
        {
            return _eventsClientService.GetAttendedEvents(username);
        }

        public ResultsPage GetUserPastEvents(string username)
        {
            return _eventsClientService.GetUserPastEvents(username);
        }
    }
}
