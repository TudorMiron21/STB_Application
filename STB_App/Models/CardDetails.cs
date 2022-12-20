using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace STB_App.Models
{
    public partial class CardDetails
    {
        public int CardId { get; set; }
        public int PersoanaId { get; set; }
        public string NumarCard { get; set; }
        public string DataExpirare { get; set; }
        public string Cvv { get; set; }

        public virtual Person Persoana { get; set; }
    }
}
