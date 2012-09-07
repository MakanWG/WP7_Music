﻿using System;
using WG.Network.Phone.Query;

namespace Songkick.Client.Phone.Contracts
{
    public interface IEventsClientService
    {
        void SearchEvents(long location, Action<EntityWrapper> callBack, string artistName = "", string minDate = "", string maxDate = "");

        void GetAttendedEvents(string username, Action<EntityWrapper> callback);

        void GetUserPastEvents(string username, Action<EntityWrapper> callback);
    }
}
