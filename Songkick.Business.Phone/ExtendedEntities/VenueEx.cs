using System;
using System.Device.Location;
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
    public class VenueEx : Venue
    {
        public VenueEx()
        {
                
        }
        public VenueEx(Venue venue)
        {
            this.Capacity = venue.Capacity;
            this.City = venue.City;
            this.Description = venue.Description;
            this.DisplayName = venue.DisplayName;
            this.Latitude = venue.Latitude;
            this.Longitude = venue.Longitude;
            this.MetroArea = venue.MetroArea;
            this.Page = venue.Page;
            this.Phone = venue.Phone;
            this.Street = venue.Street;
            this.Uri = venue.Uri;
            this.VenueId = venue.VenueId;
            this.Website = venue.Website;
            this.Zip = venue.Zip;
            this.FullAddress = venue.City.State != null ? 
                string.Format("{0}, {1}, {2}, {3}, {4}", venue.Street, venue.Zip, venue.City.DisplayName, venue.City.State.DisplayName, venue.City.Country.DisplayName) 
                : string.Format("{0}, {1}, {2}, {3}", venue.Street, venue.Zip, venue.City.DisplayName, venue.City.Country.DisplayName);   
            if (venue.Latitude != null && venue.Longitude != null)
                    GeoCoordinate = new GeoCoordinate((double) venue.Latitude, (double)venue.Longitude);
        }

        public string FullAddress { get; set; }

        public GeoCoordinate GeoCoordinate { get; set; }
    }
}
