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
using Songkick.Presentation.Phone.Home.Controls;

namespace Songkick.Presentation.Phone.Home
{
    public class HomePanoramaViewModel : ViewModelBase
    {
        public TrackingControlViewModel TrackingControlViewModel
        {
            get { return GetValue<TrackingControlViewModel>("TrackingControlViewModel", null); }
            set { SetValue<TrackingControlViewModel>("TrackingControlViewModel", value); }
        }
        
        public HomePanoramaViewModel()
            :base()
        {
        }
    }
}
