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
using Ninject;
using WG.Presentation.Phone.Navigation;
using WG.Tools.Phone.Contracts;
using WG.Tools.Phone.Notifications;
using WG.Tools.Phone.Services;

namespace Songkick.Presentation.Phone.ServicesLocators
{
    public class ServicesLocator
    {
        private IKernel _kernel;
        public ServicesLocator(IKernel kernel)
        {
            _kernel = kernel;
        }

        public NavigationController Navigation
        {
            get { return new NavigationController(); }
        }

        public ISettingsService Settings
        {
            get { return _kernel.Get<ISettingsService>(); }
        }

        public NotificationsController Notifications
        {
            get{return new NotificationsController();}
        }
    }
}
