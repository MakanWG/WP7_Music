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
using Songkick.Business.Phone.ExtendedEntities;
using Songkick.Entities.Phone.Venues;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;

namespace Songkick.Business.Phone.Contracts
{
    public interface IVenuesBusinessService
    {
        ObservableCollection<Venue> SearchVenue(string venue);

        VenueEx GetSingleVenue(string venueQuery);

        Response GetVenueCalendar(string venueId);
    }
}
