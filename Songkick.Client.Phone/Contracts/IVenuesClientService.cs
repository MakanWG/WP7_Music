using System;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;

namespace Songkick.Client.Phone.Contracts
{
    public interface IVenuesClientService
    {
        Response SearchVenue(string venue);

        Response GetVenueCalendar(string venueId);
    }
}
