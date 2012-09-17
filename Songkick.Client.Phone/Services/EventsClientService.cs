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

        public ResultsPage SearchEvents(long location, string artistName = "", string minDate = "", string maxDate = "")
        {
            RequestObject requestObject = new RequestObject();
            if (location != 0)
            {
                requestObject.Param("location", location.ToString(CultureInfo.InvariantCulture));
            }
            return (ResultsPage)requestObject
                .SetUri(Constants.Uri)
                .AppendPath("events.json")
                .Get()
                .Param("apikey", Constants.APIKey)
                .Param("artist_name", artistName)
                .Param("min_date", minDate)
                .Param("max_date", maxDate)
                .ToResponseEntity(typeof(ResultsPage));

        }

        public ResultsPage GetAttendedEvents(string username)
        {
            RequestObject requestObject = new RequestObject();
            return (ResultsPage)requestObject
                .SetUri(Constants.Uri)
                .AppendPath("users")
                .AppendPath(username)
                .AppendPath("events.json")
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(ResultsPage));
        }

        public ResultsPage GetUserPastEvents(string username)
        {
            RequestObject requestObject = new RequestObject();
            return (ResultsPage)requestObject
                .SetUri(Constants.Uri)
                .AppendPath("users")
                .AppendPath(username)
                .AppendPath("gigography.json")
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(ResultsPage));
        }
    }
}
