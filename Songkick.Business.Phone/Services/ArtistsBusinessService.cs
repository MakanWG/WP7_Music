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
using Songkick.Entities.Phone.General;

namespace Songkick.Business.Phone.Services
{
    public class ArtistsBusinessService : IArtistsBusinessService
    {
        private IArtistsClientService _artistsClient;

        public ArtistsBusinessService(IArtistsClientService artistsClient)
        {
            _artistsClient = artistsClient;
        }

        public ResultsPage SearchArtist(string artist)
        {
            return _artistsClient.SearchArtist(artist);
        }

        public ResultsPage GetArtistCalendar(string artistId)
        {
            return _artistsClient.GetArtistCalendar(artistId);
        }
    }
}
