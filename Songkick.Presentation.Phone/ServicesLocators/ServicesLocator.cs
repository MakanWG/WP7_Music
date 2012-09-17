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
using WG.Presentation.Phone.Navigation;

namespace Songkick.Presentation.Phone.ServicesLocators
{
    public class ServicesLocator
    {
        public ServicesLocator()
        {

        }

        public NavigationController Navigation
        {
            get { return new NavigationController(); }
        }
    }
}
