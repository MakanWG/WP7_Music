using System;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;

namespace Songkick.Client.Phone.Contracts
{
    public interface IArtistsClientService
    {
        ResultsPage SearchArtist(string artist);

        ResultsPage GetArtistCalendar(string artistId);
    }
}
