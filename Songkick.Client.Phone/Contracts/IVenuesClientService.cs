using System;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;

namespace Songkick.Client.Phone.Contracts
{
    public interface IVenuesClientService
    {
        ResultsPage SearchVenue(string venue);

        ResultsPage GetVenueCalendar(string venueId);
    }
}
