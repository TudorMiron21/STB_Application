using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace STB_App.Models
{
    public partial class Category
    {
        public Category()
        {
            Person = new HashSet<Person>();
        }

        public int CategoryId { get; set; }
        public string PersonType { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
