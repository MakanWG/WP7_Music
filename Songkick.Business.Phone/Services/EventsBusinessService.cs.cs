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

namespace Songkick.Business.Phone.Services
{
    public class EventsBusinessService : IEventsBusinessService
    {
        public IEventsClientService EventsClientService { get; set; }
        public EventsBusinessService()
        {
            EventsClientService = new EventsClientService();
        }

        public void SearchEvents(long location, Action<EntityWrapper> callBack, string artistName = "", string minDate = "", string maxDate = "")
        {
            EventsClientService.SearchEvents(location, callBack, artistName = "", minDate = "", maxDate = "");
        }
    }
}
