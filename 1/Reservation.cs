using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargersManager
{
    internal class Reservation
    {
        public string StaionId { get; set; }
        public string DateTimeStart { get; set; }
        public string DateTimeEnd { get; set; }

        public Reservation(string staionId, string dateTimeStart, string dateTimeEnd)
        {
            StaionId=staionId;
            DateTimeStart=dateTimeStart;
            DateTimeEnd=dateTimeEnd;
        }
    }
}
