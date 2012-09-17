using System;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;

namespace Songkick.Client.Phone.Contracts
{
    public interface ILocationsClientService
    {
        ResultsPage SearchLocations(string artist);

        ResultsPage GetLocationCalendar(string locationId);
    }
}
