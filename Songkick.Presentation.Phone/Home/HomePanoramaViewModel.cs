﻿using System;
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
using Songkick.Presentation.Phone.Home.Controls;
using System.Collections.ObjectModel;
using Songkick.Entities.Phone.General;

namespace Songkick.Presentation.Phone.Home
{
    public class HomePanoramaViewModel : ViewModelBase
    {
        public TrackingControlViewModel TrackingControlViewModel { get; set; }
        public NearYouControlViewModel NearYouControlViewModel { get; set; }
        public FastActionsControlViewModel FastActionsControlViewModel { get; set; }
        public ICommand NavigateToAccountCommand
        {
            get { return GetValue<ICommand>("NavigateToAccountCommand", null); }
            set { SetValue("NavigateToAccountCommand", value); }
        }
        
        public HomePanoramaViewModel()
            :base()
        {
            TrackingControlViewModel = new TrackingControlViewModel();
            NearYouControlViewModel = new NearYouControlViewModel();
            FastActionsControlViewModel = new FastActionsControlViewModel();
            NavigateToAccountCommand = new WGCommand(_=> this.Services().Navigation.NavigateToAccount());
        }

        public override void Charged()
        {
           
        }
    }
}
