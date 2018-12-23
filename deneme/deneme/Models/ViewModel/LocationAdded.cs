using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deneme.Models.ViewModel
{
    public class LocationAdded
    {
        public decimal Lat { get; set; }

        public decimal Lon { get; set; }

        public static explicit operator Location(LocationAdded locationAdded)
        {
            Location location = new Location()
            {
                Lat = locationAdded.Lat,
                Lon = locationAdded.Lon
            };

            return location;
        }
    }
}