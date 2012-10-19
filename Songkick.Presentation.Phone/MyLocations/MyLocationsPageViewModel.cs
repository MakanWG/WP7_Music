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
using Songkick.Business.Phone.ExtendedEntities;
using Songkick.Entities.Phone.Venues;
using WG.Presentation.Phone.ViewModels;

namespace Songkick.Presentation.Phone.MyLocations
{
    public class MyLocationsPageViewModel : ViewModelBase
    {
        public ObservableCollection<ZoneEx> TrackedLocations
        {
            get { return GetValue<ObservableCollection<ZoneEx>>("TrackedLocations", null); }
            set { SetValue("TrackedLocations", value); }
        }

        public ICommand EndListCommand
        {
            get { return GetValue<ICommand>("EndListCommand", null); }
            set { SetValue("EndListCommand", value); }
        }



        public MyLocationsPageViewModel()
        {
            EndListCommand = new WGCommand(_ => MessageBox.Show("ITWORKS"));
        }

        public override void Charged()
        {
            this.ExecuteAsync(_=>
                TrackedLocations = this.BusinessServices().Tracking.GetTrackedMetroAreas("DavidMelo"));
        }
    }
}
