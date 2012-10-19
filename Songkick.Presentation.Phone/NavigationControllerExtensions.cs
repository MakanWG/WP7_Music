using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Songkick.Business.Phone.ExtendedEntities;
using Songkick.Entities.Phone.Events;
using WG.Presentation.Phone.Navigation;
using System.Linq;
using Microsoft.Phone.Controls;
using WG.Presentation.Phone.ViewModels;
using WG.Views.Phone;
using Ninject;
using Songkick.Entities.Phone;

namespace Songkick.Presentation.Phone
{
    public static class NavigationControllerExtensions
    {
        public const string EventParameter = "EventParameter";
        public const string ViewsAssembly = "/Songkick.Views.Phone;component";
        public static PageDeclaration CurrentPage;
        public static void NavigateTo(this NavigationController controller, ApplicationPages page)
        {
            var kernel = Initializer.GetKernel();
            var module = (Module)kernel.GetModules().Select(modul => modul).Single(modul => modul.GetType() == typeof(Module));
            CurrentPage = module.Pages
                .Select(p => p).Single(p => (ApplicationPages)p.ApplicationPage == page);
            var currentRoot = (PhoneApplicationFrame)Initializer.GetApp().RootVisual;
            controller.NavigateTo(String.Format("{0}{1}",ViewsAssembly,CurrentPage.Uri), currentRoot, SetViewModel);  
        }
        public static void NavigateTo(this NavigationController controller, ApplicationPages page, Tuple<string,object> tuple )
        {
            var kernel = Initializer.GetKernel();
            var module = (Module)kernel.GetModules().Select(modul => modul).Single(modul => modul.GetType() == typeof(Module));
            CurrentPage = module.Pages
                .Select(p => p).Single(p => (ApplicationPages)p.ApplicationPage == page);
            var app =  Initializer.GetApp();
            app.Resources.Add(tuple.Item1, tuple.Item2);
            var currentRoot = (PhoneApplicationFrame)app.RootVisual;
            controller.NavigateTo(String.Format("{0}{1}", ViewsAssembly, CurrentPage.Uri), currentRoot, SetViewModel);
        }

        public static EventEx GetEventParameter(this NavigationController controller)
        {
            return (EventEx)GetParameter(EventParameter);
        }

        private static object GetParameter(string key)
        {
            var parameter = Initializer
                                .GetApp()
                                .Resources
                                .Select(o => o)
                                .Single( o =>  o.Key.ToString() == key)
                                .Value;
            Initializer
                .GetApp()
                .Resources
                .Remove(key);
            return parameter;
        }

        public static void NavigateToHome(this NavigationController controller, ApplicationPages page)
        {
            NavigateTo(controller, ApplicationPages.Home);
        }

        public static void NavigateToCalendar(this NavigationController controller)
        {
            NavigateTo(controller, ApplicationPages.Calendar);
        }

        public static void NavigateToMyArtists(this NavigationController controller)
        {
            NavigateTo(controller, ApplicationPages.MyArtists);
        }

        public static void NavigateToMyLocations(this NavigationController controller)
        {
            NavigateTo(controller, ApplicationPages.MyLocations);
        }

        public static void NavigateToAccount(this NavigationController controller)
        {
            NavigateTo(controller, ApplicationPages.Account);
        }

        public static void NavigateBack(this NavigationController controller)
        {
            var currentRoot = (PhoneApplicationFrame)Initializer.GetApp().RootVisual;
            controller.GoBack(currentRoot);
        }

        public static void NavigateToEventDetail(this NavigationController controller, object e)
        {
            var tuple = Tuple.Create(EventParameter, e);
            NavigateTo(controller, ApplicationPages.EventDetail, tuple);
        }

        public static void SetViewModel(PhoneApplicationPage root)
        {
            root.DataContext = CurrentPage.ViewModel;
            var vm = (ViewModelBase) CurrentPage.ViewModel;
            vm.Charged();
        }
    }
}
