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
using Songkick.Entities.Phone.General;

namespace Songkick.Business.Phone.Services
{
    public class LocationsBusinessService : ILocationsBusinessService
    {
        private ILocationsClientService _locationsClientService;
        public LocationsBusinessService(ILocationsClientService locationClientService)
        {
            _locationsClientService = locationClientService;
        }

        public ResultsPage SearchLocations(string artist)
        {
            return _locationsClientService.SearchLocations(artist);
        }

        public ResultsPage GetLocationCalendar(string locationId)
        {
            return _locationsClientService.GetLocationCalendar(locationId);
        }
    }
}
