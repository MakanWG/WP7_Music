using System;
using System.Collections.Generic;
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
using Songkick.Business.Phone.ExtendedEntities;
using Songkick.Client.Phone.Contracts;
using Songkick.Entities.Phone.Events;
using Songkick.Entities.Phone.Venues;
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

        public Tuple<int,IEnumerable<WGGrouping<Char, Artist>>> GetTrackedArtists(string username, int page)
        {
            var tracking = _trackingClientService
                .GetTrackedArtists(username, page)
                .ResultsPage;
            return Tuple.Create(tracking.TotalEntries, tracking
                .Results
                .Artists
                .GroupBy(artist => artist.DisplayName.ToLower().First())
                .Select(group => new WGGrouping<Char, Artist>(group)));
        }

        public ObservableCollection<ZoneEx> GetTrackedMetroAreas(string username)
        {
            return new ObservableCollection<ZoneEx>(
                _trackingClientService
                .GetTrackedLocations(username)
                .ResultsPage
                .Results
                .MetroAreas
                .Select(zone => new ZoneEx(zone)));
        }
    }
}
