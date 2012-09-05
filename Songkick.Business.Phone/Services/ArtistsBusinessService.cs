using System;
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
using WG.Network.Phone.Query;
using Songkick.Client.Phone.Contracts;
using Songkick.Client.Phone.Services;

namespace Songkick.Business.Phone.Services
{
    public class ArtistsBusinessService : IArtistsBusinessService
    {
        public IArtistsClientService ArtistsClient { get; set; }

        public ArtistsBusinessService()
        {
            ArtistsClient = new ArtistsClientService();
        }

        public void SearchArtist(string artist, Action<EntityWrapper> callback)
        {
            ArtistsClient.SearchArtist(artist, callback);
        }

        public void GetArtistCalendar(string artistId, Action<EntityWrapper> callback)
        {
            ArtistsClient.GetArtistCalendar(artistId, callback);
        }
    }
}
