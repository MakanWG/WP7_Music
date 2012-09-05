using System;
using WG.Network.Phone.Query;

namespace Songkick.Client.Phone.Contracts
{
    public interface ILocationsClientService
    {
        void SearchLocations(string artist, Action<EntityWrapper> callback);

        void GetLocationCalendar(string locationId, Action<EntityWrapper> callback);
    }
}
