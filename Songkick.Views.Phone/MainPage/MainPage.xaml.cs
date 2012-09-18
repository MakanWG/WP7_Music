using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Songkick.Presentation.Phone.MainPage;
using Songkick.Presentation.Phone;

namespace Songkick.Views.Phone.MainPage
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void test(object sender, RoutedEventArgs e)
        {
            Initializer.SetApp(Application.Current);
            EmptyViewModel model = new EmptyViewModel();
            this.DataContext = model;
            model.SetPage();
        }
    }
}