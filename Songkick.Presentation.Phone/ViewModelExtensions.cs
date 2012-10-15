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
using Songkick.Client.Phone;
using Songkick.Business.Phone;
using Songkick.Presentation.Phone.ServicesLocators;
using Ninject;

namespace Songkick.Presentation.Phone
{
    public static class ViewModelExtensions
    {
        public static ClientServicesLocator ClientServices(this ViewModelBase vmbase)
        {
            return new ClientServicesLocator();
        }

        public static BusinessServicesLocator BusinessServices(this ViewModelBase vmbase)
        {
            return Initializer.GetKernel().Get<BusinessServicesLocator>();
        }

        public static ServicesLocator Services(this ViewModelBase vmbase)
        {
            return Initializer.GetKernel().Get<ServicesLocator>();
        }
    }
}
