using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargersManager
{
    internal class Stations
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Spots { get; set; }
        public string State { get; set; }
        public string Paying { get; set; }

        public Stations(string id, string name, string address, string spots, string state, string paying)
        {
            Id = id;
            Name = name;
            Address = address;
            Spots = spots;
            State=state;
            Paying=paying;
        }
    }
}
