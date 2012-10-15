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
using WG.Presentation.Phone.ViewModels;
using WG.Tools.Phone.Helpers;

namespace Songkick.Presentation.Phone.MyArtists
{
    public class MyArtistsPageViewModel : ViewModelBase
    {
        public ObservableCollection<WGGrouping<Char, Artist>> TrackedArtists
        {
            get { return GetValue<ObservableCollection<WGGrouping<Char, Artist>>>("TrackedArtists", null); }
            set {SetValue("TrackedArtists", value);}
        }

        public MyArtistsPageViewModel()
        {
                
        }

        public override void Charged()
        {
            this.ExecuteAsync(_ =>
            TrackedArtists = this
                .BusinessServices()
                .Tracking
                .GetTrackedArtists("DavidMelo"));
        }
    }
}
