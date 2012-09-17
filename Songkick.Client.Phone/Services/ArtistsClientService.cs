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

        public ResultsPage SearchArtist(string artist)
        {
            RequestObject requestObject = new RequestObject();
            return (ResultsPage)requestObject
                .SetUri(Constants.Uri)
                .AppendPath("search")
                .AppendPath("artists.json")
                .Param("query", artist)
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(ResultsPage));
        }

        public ResultsPage GetArtistCalendar(string artistId)
        {
            RequestObject requestObject = new RequestObject();
            return (ResultsPage)requestObject
                .SetUri(Constants.Uri)
                .AppendPath("artist")
                .AppendPath(artistId)
                .AppendPath("calendar.json")
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(ResultsPage));
        }


    }
}
