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

        public void SearchLocations(string location, Action<EntityWrapper> callback)
        {
            RequestObject requestObject = new RequestObject();
            requestObject
                .SetUri(Constants.Uri)
                .AppendPath("search")
                .AppendPath("locations.json")
                .Param("query", location)
                .Param("apikey", Constants.APIKey)
                .SetCallBack(callback)
                .ToResponseEntity(typeof(ResultsPage));
            QueryHandler.ExecuteQuery(requestObject);
        }

        public void GetLocationCalendar(string locationId, Action<EntityWrapper> callback)
        {
            RequestObject requestObject = new RequestObject();
            requestObject
                .SetUri(Constants.Uri)
                .AppendPath("metro_areas")
                .AppendPath(locationId)
                .AppendPath("calendar.json")
                .Param("apikey", Constants.APIKey)
                .SetCallBack(callback)
                .ToResponseEntity(typeof(ResultsPage));
            QueryHandler.ExecuteQuery(requestObject);
        }
    }
}
