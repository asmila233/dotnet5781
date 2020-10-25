using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dotnet5781_9209_6071
{
    class Bus
    {
        private int license_plate;
        private int start_date;
        private int kilometrage;
        private int service_date;
        private int fuel; 
        public Bus(int plate_input, int date_in)
        {
            license_plate = plate_input;
            start_date = date_in;
            kilometrage = 0;
        }
        public bool is_proper(int travel_distance, int date)
        {
            bool distance = (((kilometrage % 20000) + travel_distance) < 20000);
            bool time = 
            return (time && distance);      
        }


    }
}
