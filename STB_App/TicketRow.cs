using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STB_App
{
    public partial class TicketRow
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int Route { get; set; }

        public TicketRow(int id, int route, string date)
        {
            Id = id;
            Date = date;
            Route = route;
        }
    }
}
