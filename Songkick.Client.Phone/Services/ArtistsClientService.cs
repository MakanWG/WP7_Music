using System;
using WG.Network.Phone.Query;
using WG.Extensions.Phone.Query;
using Songkick.Entities.Phone.General;
using Songkick.Client.Phone.Contracts;

namespace Songkick.Client.Phone.Services
{
    public class ArtistsClientService : IArtistsClientService
    {
        public ArtistsClientService()
        {
            
        }

        public void SearchArtist(string artist, Action<EntityWrapper> callback)
        {
            RequestObject requestObject = new RequestObject();
            requestObject
                .SetUri(Constants.Uri)
                .AppendPath("search")
                .AppendPath("artists.json")
                .Param("query", artist)
                .Param("apikey", Constants.APIKey)
                .SetCallBack(callback)
                .ToResponseEntity(typeof(ResultsPage));
            QueryHandler.ExecuteQuery(requestObject);
        }

        public void GetArtistCalendar(string artistId, Action<EntityWrapper> callback)
        {
            RequestObject requestObject = new RequestObject();
            requestObject
                .SetUri(Constants.Uri)
                .AppendPath("artist")
                .AppendPath(artistId)
                .AppendPath("calendar.json")
                .Param("apikey", Constants.APIKey)
                .SetCallBack(callback)
                .ToResponseEntity(typeof(ResultsPage));
            QueryHandler.ExecuteQuery(requestObject);
        }


    }
}
