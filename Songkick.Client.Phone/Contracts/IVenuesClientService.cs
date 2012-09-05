using System;
using WG.Network.Phone.Query;

namespace Songkick.Client.Phone.Contracts
{
    public interface IVenuesClientService
    {
        void SearchVenue(string venue, Action<EntityWrapper> callback);

        void GetVenueCalendar(string venueId, Action<EntityWrapper> callback);
    }
}
