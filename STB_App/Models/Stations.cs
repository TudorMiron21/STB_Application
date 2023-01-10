using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace STB_App.Models2
{
    public partial class Stations
    {
        public Stations()
        {
            RefStationRoute = new HashSet<RefStationRoute>();
        }

        public int StationId { get; set; }
        public string StationName { get; set; }

        public virtual ICollection<RefStationRoute> RefStationRoute { get; set; }
    }
}
