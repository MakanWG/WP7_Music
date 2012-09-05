using System;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;
using WG.Extensions.Phone.Query;
using Songkick.Client.Phone.Contracts;

namespace Songkick.Client.Phone.Services
{
    public class VenuesClientService : IVenuesClientService
    {
        public VenuesClientService()
        {

        }

        public void SearchVenue(string venue, Action<EntityWrapper> callback)
        {
            RequestObject requestObject = new RequestObject();
            requestObject
                .SetUri(Constants.Uri)
                .AppendPath("search")
                .AppendPath("venues.json")
                .Param("query", venue)
                .Param("apikey", Constants.APIKey)
                .SetCallBack(callback)
                .ToResponseEntity(typeof(ResultsPage));
            QueryHandler.ExecuteQuery(requestObject);
        }

        public void GetVenueCalendar(string venueId, Action<EntityWrapper> callback)
        {
            RequestObject requestObject = new RequestObject();
            requestObject
                .SetUri(Constants.Uri)
                .AppendPath("venue")
                .AppendPath(venueId)
                .AppendPath("calendar.json")
                .Param("apikey", Constants.APIKey)
                .SetCallBack(callback)
                .ToResponseEntity(typeof(ResultsPage));
            QueryHandler.ExecuteQuery(requestObject);
        }
    }
}
