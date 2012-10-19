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
using Songkick.Entities.Phone.Venues;

namespace Songkick.Business.Phone.ExtendedEntities
{
    public class ZoneEx : Zone
    {
        public ZoneEx()
        {
            
        }

        public ZoneEx(Zone zone)
        {
            this.Country = zone.Country;
            this.DisplayName = zone.DisplayName;
            this.Latitude = zone.Latitude;
            this.Longitude = zone.Longitude;
            this.State = zone.State;
            this.Uri = zone.Uri;
            this.ZoneId = this.ZoneId;
            this.FullName = this.State != null ? 
                string.Format("{0}, {1}", this.DisplayName, this.State.DisplayName) : 
                this.DisplayName;
        }

        public string FullName { get; set; }
    }
}
