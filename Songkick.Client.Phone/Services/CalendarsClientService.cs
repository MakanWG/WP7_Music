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
using Songkick.Entities.Phone.General;
using Songkick.Client.Phone.Contracts;
using WG.Extensions.Phone.Query;
using WG.Network.Phone.Query;

namespace Songkick.Client.Phone.Services
{
    public class CalendarsClientService : ICalendarsClientService
    {
        public CalendarsClientService()
        {

        }
        public Response GetTrackedArtistsCalendar(string username)
        {
           RequestObject requestObject = new RequestObject();
           return (Response)requestObject
                .Get()
                .SetUri(Constants.Uri)
                .AppendPath("users")
                .AppendPath(username)
                .AppendPath("calendar.json")
                .Param("reason", "tracked_artist")
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(Response));
        }

        public Response GetAttendedCalendar(string username)
        {
            RequestObject requestObject = new RequestObject();
            return (Response)requestObject
                .Get()
                .SetUri(Constants.Uri)
                .AppendPath("users")
                .AppendPath(username)
                .AppendPath("calendar.json")
                .Param("reason", "attendance")
                .Param("apikey", Constants.APIKey)
                .ToResponseEntity(typeof(Response));
        }
    }
}
