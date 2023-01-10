using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace STB_App.Models
{
    public partial class SubscriptionHistory
    {
        public SubscriptionHistory()
        {
            RefRouteSubscription = new HashSet<RefRouteSubscription>();
        }

        public int SubscriptionId { get; set; }
        public int PersonId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public int? Price { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<RefRouteSubscription> RefRouteSubscription { get; set; }
    }
}
