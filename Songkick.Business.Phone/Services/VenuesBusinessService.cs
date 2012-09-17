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
    public class VenuesBusinessService : IVenuesBusinessService
    {
        private IVenuesClientService _venuesClientService;
        public VenuesBusinessService(IVenuesClientService venuesClientService)
        {
            _venuesClientService = new VenuesClientService();
        }

        public ResultsPage SearchVenue(string venue)
        {
            return _venuesClientService.SearchVenue(venue);
        }

        public ResultsPage GetVenueCalendar(string venueId)
        {
            return _venuesClientService.GetVenueCalendar(venueId);
        }
    }
}
