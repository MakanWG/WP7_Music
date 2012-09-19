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
using Songkick.Entities.Phone.General;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Songkick.Presentation.Phone.Home.Controls
{
    public class TrackingControlViewModel : ViewModelBase
    {
        public ObservableCollection<CalendarEntry> CalendarEntries
        {
            get { return GetValue<ObservableCollection<CalendarEntry>>("CalendarEntries", null); }
            set { SetValue<ObservableCollection<CalendarEntry>>("CalendarEntries", value); }
        }


        public TrackingControlViewModel()
            :base()
        {
            GetTrackings();
        }

        public void GetTrackings()
        {
            this.ExecuteAsync(func => CalendarEntries =
                this.BusinessServices().Calendar.GetTrackedArtistsCalendar("DavidMelo"));
        }
    }
}
