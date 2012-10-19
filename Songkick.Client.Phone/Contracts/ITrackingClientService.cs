using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Songkick.Entities.Phone.General;

namespace Songkick.Client.Phone.Contracts
{
    public interface ITrackingClientService
    {
        Response GetTrackedArtists(string username, int page);
        Response GetTrackedLocations(string username);
    }
}
