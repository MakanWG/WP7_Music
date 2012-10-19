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
using Songkick.Business.Phone.ExtendedEntities;
using Songkick.Entities.Phone.Events;
using Songkick.Entities.Phone.Venues;
using WG.Tools.Phone.Helpers;

namespace Songkick.Business.Phone.Contracts
{
    public interface ITrackingBusinessService
    {
        Tuple<int, IEnumerable<WGGrouping<Char, Artist>>> GetTrackedArtists(string username, int page);
        ObservableCollection<ZoneEx> GetTrackedMetroAreas(string username);
    }
}
