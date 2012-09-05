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
    public class VenuesBusinessService : IVenuesBusinessService
    {
        public IVenuesClientService VenuesClientService { get; set; }
        public VenuesBusinessService()
        {
            VenuesClientService = new VenuesClientService();
        }

        public void SearchVenue(string venue, Action<EntityWrapper> callback)
        {
            VenuesClientService.SearchVenue(venue, callback);
        }

        public void GetVenueCalendar(string venueId, Action<EntityWrapper> callback)
        {
            VenuesClientService.GetVenueCalendar(venueId, callback);
        }
    }
}
