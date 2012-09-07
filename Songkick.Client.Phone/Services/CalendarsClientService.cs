using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using WG.Network.Phone.Query;
using WG.Extensions.Phone.Query;
using Songkick.Entities.Phone.General;
using Songkick.Client.Phone.Contracts;

namespace Songkick.Client.Phone.Services
{
    public class CalendarsClientService : ICalendarsClientService
    {
        public CalendarsClientService()
        {

        }
        public void GetTrackedArtistsCalendar(string username, Action<EntityWrapper> callback)
        {
            RequestObject requestObject = new RequestObject();
            requestObject
                .SetUri(Constants.Uri)
                .AppendPath("users")
                .AppendPath(username)
                .AppendPath("calendar.json")
                .Param("reason", "tracked_artist")
                .Param("apikey", Constants.APIKey)
                .SetCallBack(callback)
                .ToResponseEntity(typeof(ResultsPage));
            QueryHandler.ExecuteQuery(requestObject);
        }

        public void GetAttendedCalendar(string username, Action<EntityWrapper> callback)
        {
            RequestObject requestObject = new RequestObject();
            requestObject
                .SetUri(Constants.Uri)
                .AppendPath("users")
                .AppendPath(username)
                .AppendPath("calendar.json")
                .Param("reason", "attendance")
                .Param("apikey", Constants.APIKey)
                .SetCallBack(callback)
                .ToResponseEntity(typeof(ResultsPage));
            QueryHandler.ExecuteQuery(requestObject);
        }
    }
}
