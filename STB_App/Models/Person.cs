using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace STB_App.Models
{
    public partial class Person
    {
        public Person()
        {
            CardDetails = new HashSet<CardDetails>();
            SubscriptionHistory = new HashSet<SubscriptionHistory>();
            TicketHistory = new HashSet<TicketHistory>();
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string UserName { get; set; }
        public string Passw { get; set; }
        public int? CategoryId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<CardDetails> CardDetails { get; set; }
        public virtual ICollection<SubscriptionHistory> SubscriptionHistory { get; set; }
        public virtual ICollection<TicketHistory> TicketHistory { get; set; }
    }
}
