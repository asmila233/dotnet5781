using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_9209_6071
{
    class Busֹֹ_Station_Number : Bus_Station
    {
        private double distance_station;
        private TimeSpan time_for_road;
        public Busֹֹ_Station_Number(double help_dis, TimeSpan help_time) 
            : base Bus_Station()
        {
            distance_station = help_dis;
           
        }
        public double get_distance_station()
        {
            return distance_station;
        }
        public void set_distance_station(double help)
        {
            distance_station = help;
        }
        public TimeSpan get_time_for_road()
        {
            return time_for_road;
        }
        public void set_time_for_road(TimeSpan help)
        {
            time_for_road = help;
        }
    }
}
