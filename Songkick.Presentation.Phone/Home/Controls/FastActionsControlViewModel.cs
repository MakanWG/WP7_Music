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
using WG.Presentation.Phone.ViewModels;

namespace Songkick.Presentation.Phone.Home.Controls
{
    public class FastActionsControlViewModel : ViewModelBase
    {
        public ICommand GoToCalendarCommand
        {
            get { return GetValue<ICommand>("GoToCalendarCommand", null); }
            set { SetValue<ICommand>("GoToCalendarCommand", value); }
        }

        public ICommand GoToMyArtistsCommand
        {
            get { return GetValue<ICommand>("GoToMyArtistsCommand", null); }
            set { SetValue<ICommand>("GoToMyArtistsCommand", value); }
        }

        public ICommand GoToMyLocationsCommand
        {
            get { return GetValue<ICommand>("GoToMyLocationsCommand", null); }
            set { SetValue<ICommand>("GoToMyLocationsCommand", value); }
        }

        public FastActionsControlViewModel()
        {
            GoToCalendarCommand = new WGCommand(_ => this.Services().Navigation.NavigateToCalendar());
            GoToMyArtistsCommand = new WGCommand(_ => this.Services().Navigation.NavigateToMyArtists());
            GoToMyLocationsCommand = new WGCommand(_ => this.Services().Navigation.NavigateToMyLocations());
        }

        public override void Charged()
        {
            
        }
    }
}
