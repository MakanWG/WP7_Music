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
using System.ComponentModel;
using System.Windows.Threading;

namespace Songkick.Presentation.Phone.MainPage
{
    public class EmptyViewModel : ViewModelBase
    {
        public ResultsPage ResultPage
        {
            get { return GetValue<ResultsPage>("ResultPage", null); }
            set { SetValue("ResultPage", value); }
        }
        public EmptyViewModel()
            :base()
        {   
            ResultPage = new ResultsPage();
        }

        public void SetPage()
        {       
                var Result = new ResultsPage();
                this.ExecuteAsync(func => Result =
                    this.BusinessServices().Calendar.GetTrackedArtistsCalendar("DavidMelo"));
                ResultPage = Result;
                this.Services().Navigation.NavigateTo(ApplicationPages.Test);
        }
    }
}
