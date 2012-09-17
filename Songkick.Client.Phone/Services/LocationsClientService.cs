using System;
using WG.Extensions.Phone.Query;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;
using Songkick.Client.Phone.Contracts;

namespace Songkick.Client.Phone.Services
{
    public class LocationsClientService : ILocationsClientService
    {
        public LocationsClientService()
        {

        }

        public ResultsPage SearchLocations(string location)
        {
            RequestObject requestObject = new RequestObject();
            return (ResultsPage)requestObject
                .SetUri(Constants.Uri)
                .AppendPath("search")
                .AppendPath("locations.json")
                .Param("query", location)
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(ResultsPage));
        }

        public ResultsPage GetLocationCalendar(string locationId)
        {
            RequestObject requestObject = new RequestObject();
            return (ResultsPage)requestObject
                .SetUri(Constants.Uri)
                .AppendPath("metro_areas")
                .AppendPath(locationId)
                .AppendPath("calendar.json")
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(ResultsPage));
        }
    }
}
