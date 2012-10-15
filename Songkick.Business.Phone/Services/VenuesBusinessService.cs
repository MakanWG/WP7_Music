using System;
using System.Collections.ObjectModel;
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
using Songkick.Business.Phone.ExtendedEntities;
using Songkick.Client.Phone.Contracts;
using Songkick.Client.Phone.Services;
using Songkick.Entities.Phone.Venues;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;
using System.Linq;

namespace Songkick.Business.Phone.Services
{
    public class VenuesBusinessService : IVenuesBusinessService
    {
        private IVenuesClientService _venuesClientService;
        public VenuesBusinessService(IVenuesClientService venuesClientService)
        {
            _venuesClientService = new VenuesClientService();
        }

        public ObservableCollection<Venue> SearchVenue(string venueQuery)
        {
            return _venuesClientService.SearchVenue(venueQuery).ResultsPage.Results.Venues;
        }

        public VenueEx GetSingleVenue(string venueQuery)
        {
            return SearchVenue(venueQuery).Select(venue => new VenueEx(venue)).First();
        }

        public Response GetVenueCalendar(string venueId)
        {
            return _venuesClientService.GetVenueCalendar(venueId);
        }
    }
}
