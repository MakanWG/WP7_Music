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
using Songkick.Business.Phone.Contracts;
using Ninject;

namespace Songkick.Presentation.Phone.ServicesLocators
{
    public class BusinessServicesLocator
    {
        private IKernel _kernel;
        public BusinessServicesLocator(IKernel kernel)
        {
            _kernel = kernel;
        }

        public IArtistsBusinessService Artists
        {
            get { return _kernel.Get<IArtistsBusinessService>(); }
        }

        public ILocationsBusinessService Locations
        {
            get { return _kernel.Get<ILocationsBusinessService>(); }
        }

        public IVenuesBusinessService Venues
        {
            get { return _kernel.Get<IVenuesBusinessService>(); }
        }

        public ICalendarsBusinessService Calendar
        {
            get { return _kernel.Get<ICalendarsBusinessService>(); }
        }

        public IEventsBusinessService Events
        {
            get { return _kernel.Get<IEventsBusinessService>(); }
        }
    }
}
