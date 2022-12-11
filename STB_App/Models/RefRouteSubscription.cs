using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace STB_App.Models
{
    public partial class RefRouteSubscription
    {
        public int RefId { get; set; }
        public int RouteId { get; set; }
        public int SubscriptionId { get; set; }

        public virtual Routes Route { get; set; }
        public virtual SubscriptionHistory Subscription { get; set; }
    }
}
