using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_9209_6071
{
    struct Location
    {
        public int Latitude;
        public int Longitude;

    };
    class Bus_Station
    {
        private int Station_code;
        private Location Station_Loc; 
        public Bus_Station(int code, Location loc)
        {
            Station_Loc = loc;
            Station_code = code;
        }
        public override string ToString()
        {
            return ("Bus Station Code:{0}"+ Station_code + "," + Station_Loc.Latitude + "°N" + "," + Station_Loc.Longitude+"°E");
        }

    }
}
