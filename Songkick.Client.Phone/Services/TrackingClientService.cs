using System;
using WG.Network.Phone.Query;
using WG.Extensions.Phone.Query;
using Songkick.Entities.Phone.General;
using Songkick.Client.Phone.Contracts;

namespace Songkick.Client.Phone.Services
{
    public class TrackingClientService : ITrackingClientService
    {
        public TrackingClientService()
        {
            
        }

        public Response GetTrackedArtists(string username)
        {
            var requestObject = new RequestObject();
            return (Response)requestObject
                .Get()
                .SetUri(Constants.Uri)
                .AppendPath("users")
                .AppendPath(username)
                .AppendPath("artists")
                .AppendPath("tracked.json")
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(Response));   
        }
    }
}
