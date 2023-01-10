using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STB_App
{
    internal class SubscriptionRow
    {

        public int Id { get; set; }
        public string DateStart { get; set; }

        public string DateFinish { get; set; }

        public string Route { get; set; }

        public SubscriptionRow(int id, string routes,string dateStart, string dateFinish)
        {
            Id = id;
            DateStart = dateStart;
            DateFinish = dateFinish;
            Route = routes;
        }
    }
}
