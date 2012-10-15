using System;
using System.Collections.ObjectModel;
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
using Songkick.Client.Phone.Contracts;
using Songkick.Entities.Phone.Events;
using WG.Tools.Phone.Helpers;
using System.Linq;

namespace Songkick.Business.Phone.Services
{
    public class TrackingBusinessService : ITrackingBusinessService
    {
        private ITrackingClientService _trackingClientService;
        public TrackingBusinessService(ITrackingClientService trackingClientService)
        {
            _trackingClientService = trackingClientService;
        }

        public ObservableCollection<WGGrouping<Char, Artist>> GetTrackedArtists(string username)
        {
            return new ObservableCollection<WGGrouping<Char, Artist>>(
                _trackingClientService
                .GetTrackedArtists(username)
                .ResultsPage
                .Results
                .Artists
                .GroupBy(artist => artist.DisplayName.ToLower().First())
                .Select(group => new WGGrouping<Char, Artist>(group)));
        }
    }
}
