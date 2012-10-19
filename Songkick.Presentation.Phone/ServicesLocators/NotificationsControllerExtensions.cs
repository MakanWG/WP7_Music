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
using Microsoft.Phone.Controls;
using WG.Tools.Phone.Notifications;

namespace Songkick.Presentation.Phone.ServicesLocators
{
    public static class NotificationsControllerExtensions
    {
        public static void SetProgress(this NotificationsController controller, string text)
        {
            var currentRoot = (PhoneApplicationFrame)Initializer.GetApp().RootVisual;
            controller.ShowProgressIndicator(currentRoot, text);
        }
    }
}
