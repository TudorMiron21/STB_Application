using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace STB_App.Models
{
    public partial class Routes
    {
        public Routes()
        {
            RefRouteSubscription = new HashSet<RefRouteSubscription>();
            TicketHistory = new HashSet<TicketHistory>();
        }

        public int RouteId { get; set; }
        public int StationDepartureId { get; set; }
        public int StationArrivalId { get; set; }

        public virtual Stations StationArrival { get; set; }
        public virtual Stations StationDeparture { get; set; }
        public virtual ICollection<RefRouteSubscription> RefRouteSubscription { get; set; }
        public virtual ICollection<TicketHistory> TicketHistory { get; set; }
    }
}
