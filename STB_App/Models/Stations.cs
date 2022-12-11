using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace STB_App.Models
{
    public partial class Stations
    {
        public Stations()
        {
            RoutesStationArrival = new HashSet<Routes>();
            RoutesStationDeparture = new HashSet<Routes>();
        }

        public int StationId { get; set; }
        public string StationName { get; set; }

        public virtual ICollection<Routes> RoutesStationArrival { get; set; }
        public virtual ICollection<Routes> RoutesStationDeparture { get; set; }
    }
}
