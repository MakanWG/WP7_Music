using System;
using WG.Network.Phone.Query;
using Songkick.Entities.Phone.General;

namespace Songkick.Client.Phone.Contracts
{
    public interface IEventsClientService
    {
        ResultsPage SearchEvents(long location, string artistName = "", string minDate = "", string maxDate = "");

        ResultsPage GetAttendedEvents(string username);

        ResultsPage GetUserPastEvents(string username);
    }
}
