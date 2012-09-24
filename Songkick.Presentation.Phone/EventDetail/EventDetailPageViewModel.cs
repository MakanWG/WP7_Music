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
using Songkick.Entities.Phone.Events;
using WG.Presentation.Phone.ViewModels;

namespace Songkick.Presentation.Phone.EventDetail
{
    public class EventDetailPageViewModel : ViewModelBase
    {
        public EventEx Event
        {
            get { return GetValue<EventEx>("Event", null); }
            set { SetValue("Event", value); }
        }

        public EventDetailPageViewModel()
            : base()
        {

        }

        public override void Charged()
        {
            Event = this.Services().Navigation.GetEventParameter();
        }
    }
}
