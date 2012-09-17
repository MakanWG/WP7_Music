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
using Microsoft.Phone.Reactive;
using System.Linq;
using Microsoft.Phone.Controls;
using WG.Views.Phone;

namespace Songkick.Presentation.Phone
{
    public static class NavigationControllerExtensions
    {
        public const string ViewsAssembly = "/Songkick.Views.Phone;component";
        public static PageDeclaration CurrentPage;
        public static void NavigateTo(this NavigationController controller, ApplicationPages Page)
        {
            var kernel = Initializer.GetKernel();
            Module module = (Module)kernel.GetModules().Select(modul => modul).Where(modul => modul.GetType() == typeof(Module)).Single();
            CurrentPage = module.Pages
                .Select(p => p)
                .Where(p => (ApplicationPages)p.ApplicationPage == Page)
                .Single();
            var currentRoot = (PhoneApplicationFrame)Initializer.GetApp().RootVisual;
            controller.NavigateTo(String.Format("{0}{1}",ViewsAssembly,CurrentPage.Uri), currentRoot, SetViewModel);  
        }

        public static void SetViewModel(PhoneApplicationPage root)
        {
            root.DataContext = CurrentPage.ViewModel;
        }
    }
}
