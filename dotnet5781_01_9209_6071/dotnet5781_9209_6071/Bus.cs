using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace dotnet5781_9209_6071
{
    class Bus
    {
        private int license_plate;
        private DateTime start_date;
        private int kilometrage;
        private int km_since_service;
        private DateTime service_date;
        private int fuel;
        public Bus(int plate_input, DateTime date_in)
        {
            license_plate = plate_input;
            start_date = date_in;
            kilometrage = 0;
            km_since_service = 0;
            service_date = date_in;
        }
        public Bus()
        {
            license_plate = 0;

        }
        public DateTime date_get()
        {
            return service_date;
        }
        public void date_set(DateTime date)
        {
            service_date = date;
        }
        public int license_get()
        {
            return license_plate;
        }
        //no need for license plate setter
        public int fuel_get()
        {
            return fuel;
        }
        public void refuel()
        {
            fuel = 1200;
        }

        public bool enough_fuel(int distance)
        {
            if (distance < fuel)
                return true;
            else
                return false;
        }
        public bool is_proper(int travel_distance, DateTime date)
        {
            bool distance = ((km_since_service + travel_distance) < 20000);

            TimeSpan remainder = (date - service_date);
            TimeSpan FullYear = new TimeSpan(365, 0, 0, 0, 0);

            bool time = (FullYear > remainder);

            if (distance && time)
            {
                Console.WriteLine("Your bus is ready to go");
                return true;
            }
            else
            {
                Console.WriteLine("Service now, can't travel");
                return false;
            }
        }


    }
}
