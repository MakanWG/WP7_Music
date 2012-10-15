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

        public Response SearchVenue(string venue)
        {
            var requestObject = new RequestObject();
            return (Response)requestObject
                .Get()
                .SetUri(Constants.Uri)
                .AppendPath("search")
                .AppendPath("venues.json")
                .Param("query", venue)
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(Response));
        }

        public Response GetVenueCalendar(string venueId)
        {
            var requestObject = new RequestObject();
            return (Response)requestObject
                .SetUri(Constants.Uri)
                .AppendPath("venue")
                .AppendPath(venueId)
                .AppendPath("calendar.json")
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(Response));
        }
    }
}
