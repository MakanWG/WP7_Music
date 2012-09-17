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

        public ResultsPage SearchVenue(string venue)
        {
            RequestObject requestObject = new RequestObject();
            return (ResultsPage)requestObject
                .SetUri(Constants.Uri)
                .AppendPath("search")
                .AppendPath("venues.json")
                .Param("query", venue)
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(ResultsPage));
        }

        public ResultsPage GetVenueCalendar(string venueId)
        {
            RequestObject requestObject = new RequestObject();
            return (ResultsPage)requestObject
                .SetUri(Constants.Uri)
                .AppendPath("venue")
                .AppendPath(venueId)
                .AppendPath("calendar.json")
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(ResultsPage));
        }
    }
}
