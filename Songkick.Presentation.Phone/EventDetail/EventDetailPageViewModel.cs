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
using Songkick.Entities.Phone.Venues;
using WG.Presentation.Phone.ViewModels;
using Microsoft.Phone.Tasks;


namespace Songkick.Presentation.Phone.EventDetail
{
    public class EventDetailPageViewModel : ViewModelBase
    {
        public EventEx Event
        {
            get { return GetValue<EventEx>("Event", null); }
            set { SetValue("Event", value);
                    CompleteVenue(value);}
        }

        private string VenueQuery { get; set; }

        public VenueEx Venue
        {
            get { return GetValue<VenueEx>("Venue", null); }
            set { SetValue("Venue", value); }
        }

        public EventDetailPageViewModel()
            : base()
        {

        }

        public override void Charged()
        {
            Event = this.Services().Navigation.GetEventParameter();
            SearchOnBingCommand = new WGCommand(_ => SearchOnBing());
        }

        private void CompleteVenue(EventEx eventEx)
        {
            VenueQuery = string.Format("{0} {1}", eventEx.Venue.DisplayName, eventEx.EventLocation.City);
            this.ExecuteAsync(_ => Venue = this
                                            .BusinessServices()
                                            .Venues.GetSingleVenue(VenueQuery));
        }

        public ICommand SearchOnBingCommand { get; set; }

        private void SearchOnBing()
        {
            var map = new BingMapsTask {SearchTerm = Venue.FullAddress};
            map.Show();
        }
    }
}
