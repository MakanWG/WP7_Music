using Ninject.Modules;
using Songkick.Client.Phone.Contracts;
using Songkick.Client.Phone.Services;
using Songkick.Business.Phone.Contracts;
using Songkick.Business.Phone.Services;
using Songkick.Presentation.Phone.Calendar;
using Songkick.Presentation.Phone.MyArtists;
using Songkick.Presentation.Phone.ServicesLocators;
using WG.Tools.Phone.Contracts;
using WG.Views.Phone;
using Songkick.Presentation.Phone.MainPage;
using System.Collections;
using Songkick.Presentation.Phone.Home;
using Songkick.Presentation.Phone.EventDetail;
using WG.Tools.Phone.Services;

namespace Songkick.Presentation.Phone
{
    public class Module : NinjectModule
    {
        public Module()
        {
        }
        public PageDeclaration[] Pages { get; set; }

        public override void Load()
        {
            RegisterClientInterfaces();
            RegisterBusinessInterfaces();
            RegisterPages();
        }

        private void RegisterClientInterfaces()
        {
            Bind<ClientServicesLocator>().To<ClientServicesLocator>();
            Bind<IArtistsClientService>().To<ArtistsClientService>();
            Bind<ICalendarsClientService>().To<CalendarsClientService>();
            Bind<IEventsClientService>().To<EventsClientService>();
            Bind<ILocationsClientService>().To<LocationsClientService>();
            Bind<IVenuesClientService>().To<VenuesClientService>();
            Bind<ITrackingClientService>().To<TrackingClientService>();
        }

        private void RegisterBusinessInterfaces()
        {
            Bind<BusinessServicesLocator>().To<BusinessServicesLocator>();
            Bind<ICalendarsBusinessService>().To<CalendarsBusinessService>();
            Bind<IArtistsBusinessService>().To<ArtistsBusinessService>();
            Bind<IEventsBusinessService>().To<EventsBusinessService>();
            Bind<ILocationsBusinessService>().To<LocationsBusinessService>();
            Bind<IVenuesBusinessService>().To<VenuesBusinessService>();
            Bind<ITrackingBusinessService>().To<TrackingBusinessService>();
        }

        private void RegisterServicesInterface()
        {
            Bind<ServicesLocator>().To<ServicesLocator>();
            Bind<ISettingsService>().To<SettingsService>();
        }

        private void RegisterPages()
        {
            Pages = new[]
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
               new PageDeclaration
               {
                   ApplicationPage = ApplicationPages.EventDetail,
                   Uri = "/EventDetail/EventDetailPage.xaml",
                   ViewModel = new EventDetailPageViewModel()
               },
               new PageDeclaration
               {
                   ApplicationPage = ApplicationPages.Calendar,
                   Uri = "/Calendar/CalendarPivot.xaml",
                   ViewModel = new CalendarPivotViewModel()
               },
               new PageDeclaration
               {
                   ApplicationPage = ApplicationPages.MyArtists,
                   Uri = "/MyArtists/MyArtistsPage.xaml",
                   ViewModel = new MyArtistsPageViewModel()
               },
           };
        }
    }
}
