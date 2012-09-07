using System;
using Songkick.Client.Phone.Contracts;
using WG.Network.Phone.Query;
using WG.Extensions.Phone.Query;
using Songkick.Entities.Phone.General;
using System.Globalization;

namespace Songkick.Client.Phone.Services
{
    public class EventsClientService : IEventsClientService
    {
        public EventsClientService()
        {

        }

        public void SearchEvents(long location , Action<EntityWrapper> callBack, string artistName = "", string minDate = "", string maxDate ="")
        {
            RequestObject RequestObject = new RequestObject();
            RequestObject
                .SetUri(Constants.Uri)
                .AppendPath("events.json")
                .Get()
                .Param("apikey", Constants.APIKey)
                .Param("artist_name", artistName)
                .Param("min_date", minDate)
                .Param("max_date", maxDate)
                .SetCallBack(callBack)
                .ToResponseEntity(typeof(ResultsPage));
            if (location != 0)
            {
                RequestObject.Param("location", location.ToString(CultureInfo.InvariantCulture));
            }
            QueryHandler.ExecuteQuery(RequestObject);
        }

        public void GetAttendedEvents(string username, Action<EntityWrapper> callback)
        {
            RequestObject requestObject = new RequestObject();
            requestObject
                .SetUri(Constants.Uri)
                .AppendPath("users")
                .AppendPath(username)
                .AppendPath("events.json")
                .Param("apikey", Constants.APIKey)
                .SetCallBack(callback)
                .ToResponseEntity(typeof(ResultsPage));
            QueryHandler.ExecuteQuery(requestObject);
        }

        public void GetUserPastEvents(string username, Action<EntityWrapper> callback)
        {
            RequestObject requestObject = new RequestObject();
            requestObject
                .SetUri(Constants.Uri)
                .AppendPath("users")
                .AppendPath(username)
                .AppendPath("gigography.json")
                .Param("apikey", Constants.APIKey)
                .SetCallBack(callback)
                .ToResponseEntity(typeof(ResultsPage));
            QueryHandler.ExecuteQuery(requestObject);
        }
    }
}
