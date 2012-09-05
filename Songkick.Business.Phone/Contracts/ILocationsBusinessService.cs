﻿using System;
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

namespace Songkick.Business.Phone.Contracts
{
    public interface ILocationsBusinessService
    {
        void SearchLocations(string artist, Action<EntityWrapper> callback);

        void GetLocationCalendar(string locationId, Action<EntityWrapper> callback);
    }
}