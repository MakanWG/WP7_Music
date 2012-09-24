using System;
using System.Net;
using System.Threading;
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
        public EmptyViewModel()
            :base()
        {   
        }

        public void SetPage()
        {       
            this.Services().Navigation.NavigateTo(ApplicationPages.Home);
        }

        public override void Charged()
        {
           
        }
    }
}
