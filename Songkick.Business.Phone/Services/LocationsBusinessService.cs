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
using Songkick.Business.Phone.Contracts;
using WG.Network.Phone.Query;
using Songkick.Client.Phone.Contracts;
using Songkick.Client.Phone.Services;

namespace Songkick.Business.Phone.Services
{
    public class LocationsBusinessService : ILocationsBusinessService
    {
        public ILocationsClientService LocationsClientService { get; set; }
        public LocationsBusinessService()
        {
            LocationsClientService = new LocationsClientService();
        }

        public void SearchLocations(string artist, Action<EntityWrapper> callback)
        {
            LocationsClientService.SearchLocations(artist, callback);
        }

        public void GetLocationCalendar(string locationId, Action<EntityWrapper> callback)
        {
            LocationsClientService.GetLocationCalendar(locationId, callback);
        }
    }
}
