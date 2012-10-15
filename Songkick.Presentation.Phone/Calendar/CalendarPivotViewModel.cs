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
using Songkick.Presentation.Phone.Calendar.UserControls;
using WG.Presentation.Phone.ViewModels;

namespace Songkick.Presentation.Phone.Calendar
{
    public class CalendarPivotViewModel : ViewModelBase
    {
        public ArtistsUserControlViewModel ArtistsUserControlViewModel { get; set; }
        public PlansUserControlViewModel PlansUserControlViewModel { get; set; }
        public override void Charged()
        {
            ArtistsUserControlViewModel = new ArtistsUserControlViewModel();
            PlansUserControlViewModel = new PlansUserControlViewModel();
        }

        public CalendarPivotViewModel()
        {
                
        }
    }
}
