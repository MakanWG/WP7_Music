using Ninject.Modules;
using Songkick.Client.Phone.Contracts;
using Songkick.Client.Phone.Services;
using Songkick.Business.Phone.Contracts;
using Songkick.Business.Phone.Services;
using Songkick.Presentation.Phone.ServicesLocators;
using WG.Views.Phone;
using Songkick.Presentation.Phone.MainPage;
using System.Collections;
using Songkick.Presentation.Phone.Home;

namespace Songkick.Presentation.Phone
{
    public class Module : NinjectModule
    {
        public PageDeclaration[] Pages { get; set; }
        public override void Load()
        {
            RegisterClientInterfaces();
            RegisterBusinessInterfaces();
            RegisterPages();
        }

        private void RegisterClientInterfaces()
        {
            Bind<IArtistsClientService>().To<ArtistsClientService>();
            Bind<ICalendarsClientService>().To<CalendarsClientService>();
            Bind<IEventsClientService>().To<EventsClientService>();
            Bind<ILocationsClientService>().To<LocationsClientService>();
            Bind<IVenuesClientService>().To<VenuesClientService>();
        }

        private void RegisterBusinessInterfaces()
        {
            Bind<ICalendarsBusinessService>().To<CalendarsBusinessService>();
            Bind<IArtistsBusinessService>().To<ArtistsBusinessService>();
            Bind<IEventsBusinessService>().To<EventsBusinessService>();
            Bind<ILocationsBusinessService>().To<LocationsBusinessService>();
            Bind<IVenuesBusinessService>().To<VenuesBusinessService>();
        }

        private void RegisterPages()
        {
            Pages = new PageDeclaration[]
           {
               new PageDeclaration
               {
                   ApplicationPage = ApplicationPages.Main, 
                   Uri = "/MainPage/MainPage.xaml",
                   ViewModel = new EmptyViewModel()
               },
               new PageDeclaration
               {
                   ApplicationPage = ApplicationPages.Home,
                   Uri = "/Home/HomePanorama.xaml",
                   ViewModel = new HomePanoramaViewModel()
               },
           };
        }
    }
}
