using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace STB_App.Models2
{
    public partial class TicketHistory
    {
        public int TicketId { get; set; }
        public int PersonId { get; set; }
        public int RouteId { get; set; }
        public DateTime? DataBilet { get; set; }

        public virtual Person Person { get; set; }
        public virtual Routes Route { get; set; }
    }
}
