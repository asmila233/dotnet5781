using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace dotNet5781_9209_6071
{
    class Bus
    {
        private int license_plate;
        private DateTime start_date;
        private int kilometrage;
        private int km_since_service;
        private DateTime service_date;
        private int fuel;
        //constructor
        public Bus(int plate_input, DateTime date_in)
        {
            license_plate = plate_input;
            start_date = date_in;
            kilometrage = 0;
            km_since_service = 0;
            service_date = date_in;
        }
        public Bus()
        { }
        // setters and getters
        public int km_get()
        {
            return kilometrage;
        }
        public DateTime date_get()
        {
            return service_date;
        }
        public void date_set(DateTime date)
        {
            service_date = date; 
        }
        public void set_km_si_se(int num)
        {
            km_since_service = num;
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
        public int km_since_servic_get()
        {
            return km_since_service;
        }
        // updates every field in the class after travelling
        public void travel_update(int distance_traveled)
        {
            km_since_service += distance_traveled;
            kilometrage += distance_traveled;
            fuel -= distance_traveled;
        }
        //updates the fuel levels after refuel
        public void refuel()
        {
            fuel = 1200;
        }
        // checks if there is enough fuel to perform the trip
        public bool enough_fuel(int distance)
        {
            if (distance < fuel)
                return true;
            else
                return false;
        }
        //check if the bus can travel the distance without the need for service
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

        public int print_digit(int num)
        {
            int[] digit_7 = new int[7];
            int[] digit_8 = new int[8];
            if (num_of_digit(num) == 7)
            {
                for (int i = 10, j = 7; j > 0; i *= 10, j--)
                    digit_7[j - 1] = (num % i) / (i / 10);
                Console.Write("{0}{1}-{2}{3}{4}-{5}", digit_7[0], digit_7[1], digit_7[2], digit_7[3], digit_7[4], digit_7[5]);
                return digit_7[6];
            }
            else if (num_of_digit(num) == 8)
            {
                for (int i = 10, j = 8; j > 0; i *= 10, j--)
                    digit_8[j - 1] = (num % i) / (i / 10);
                Console.Write("{0}{1}{2}-{3}{4}-{5}{6}", digit_8[0], digit_8[1], digit_8[2], digit_8[3], digit_8[4], digit_8[5], digit_8[6]);
                return digit_8[7];
            }
            else
            {
                Console.WriteLine("Error");
                return -1;
            }
        }
        public int num_of_digit(int num)
        {
            int sum = 0;
            for (int i = 10; i <= num * 10; i *= 10, sum++) ;
            return sum;
        }
    }
}
