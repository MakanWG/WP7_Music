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

namespace Songkick.Presentation.Phone.Home.Controls
{
    public class TrackingControlViewModel : ViewModelBase
    {
        public Response Response
        {
            get { return GetValue<Response>("Response", null); }
            set { SetValue<Response>("Response", value); }
        }
        public TrackingControlViewModel()
            :base()
        {
            GetTrackings();
        }

        public void GetTrackings()
        {
            var Result = new Response();
            this.ExecuteAsync(func => Response =
                this.BusinessServices().Calendar.GetTrackedArtistsCalendar("DavidMelo"), Result);
        }
    }
}
