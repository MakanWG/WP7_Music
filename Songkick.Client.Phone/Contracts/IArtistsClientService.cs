using System;
using WG.Network.Phone.Query;

namespace Songkick.Client.Phone.Contracts
{
    public interface IArtistsClientService
    {
        void SearchArtist(string artist, Action<EntityWrapper> callback);

        void GetArtistCalendar(string artistId, Action<EntityWrapper> callback);
    }
}
