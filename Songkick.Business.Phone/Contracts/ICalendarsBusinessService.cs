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
using Songkick.Business.Phone.ExtendedEntities;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WG.Tools.Phone.Helpers;

namespace Songkick.Business.Phone.Contracts
{
    public interface ICalendarsBusinessService
    {
        ObservableCollection<WGGrouping<DateTimeOffset, CalendarEntryEx>> GetTrackedArtistsCalendar(string username);

        ObservableCollection<WGGrouping<DateTimeOffset, CalendarEntryEx>> GetAttendedCalendar(string username);
    }
}
