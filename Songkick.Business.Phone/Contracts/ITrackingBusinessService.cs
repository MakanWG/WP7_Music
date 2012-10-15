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
using Songkick.Entities.Phone.Events;
using WG.Tools.Phone.Helpers;

namespace Songkick.Business.Phone.Contracts
{
    public interface ITrackingBusinessService
    {
        ObservableCollection<WGGrouping<Char, Artist>> GetTrackedArtists(string username);
    }
}
