﻿using System;
using System.Collections.ObjectModel;
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
using WG.Presentation.Phone.ViewModels;
using WG.Tools.Phone.Helpers;

namespace Songkick.Presentation.Phone.Calendar.UserControls
{
    public class PlansUserControlViewModel : ViewModelBase
    {
        public ObservableCollection<WGGrouping<DateTimeOffset, CalendarEntryEx>> CalendarEntries
        {
            get { return GetValue<ObservableCollection<WGGrouping<DateTimeOffset, CalendarEntryEx>>>("CalendarEntries", null); }
            set { SetValue<ObservableCollection<WGGrouping<DateTimeOffset, CalendarEntryEx>>>("CalendarEntries", value); }
        }

        public ICommand GoToEventCommand
        {
            get { return GetValue<ICommand>("GoToEventCommand", null); }
            set { SetValue<ICommand>("GoToEventCommand", value); }
        }

        public PlansUserControlViewModel()
        {
            GetAttendance();
            GoToEventCommand = new WGCommand(e => this.Services().Navigation.NavigateToEventDetail(e));
        }

        public override void Charged()
        {
            
        }

        private void GetAttendance()
        {
            this.ExecuteAsync(func => CalendarEntries =
                this.BusinessServices().Calendar.GetAttendedCalendar("DavidMelo"));
        }
    }
}
