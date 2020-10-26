using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_9209_6071
{
    enum State { Add = 1, Choose = 2, GAS = 3, KM = 4, exit =5 };
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Bus> bus_list = new Dictionary<int, Bus>();
            State the_choose;
            bool flag1 = true;
            while (flag1)
            {
                Console.WriteLine("Please select an option from the menu:");
                Console.WriteLine("ADD bus to the list of buses in the company - 1");
                Console.WriteLine("Choosing a bus to travel - 2");
                Console.WriteLine("Do refueling or handling of a bus - 3");
                Console.WriteLine("Viewing the passenger since the last treatment for all the car in the company - 4");
                Console.WriteLine("EXIT - 5");
                the_choose = (State)Console.Read();
                int help_license,help;
                DateTime a;
                Bus bus123 = new Bus();
                switch (the_choose)
                {
                    case State.Add:
                        Console.WriteLine("Enter the license number, and the start date of the activity");
                        help_license = int.Parse(Console.ReadLine());

                        bus_list.Add(help_license, bus123);
                        break;

                    case State.Choose:
                        Console.WriteLine("Enter the license number");
                        help_license = int.Parse(Console.ReadLine());
                        Random r = new Random(DateTime.Now.Millisecond);
                        int r1 = r.Next(1,1200);
                        if (bus_list.ContainsValue(bus123))
                            Console.WriteLine("The bus does not exist in the system");
                        else if(r1 > 20000 || )
                            Console.WriteLine("the car wont able to drive");
                        break;

                    case State.GAS:

                        break;

                    case State.KM:

                        break;

                    case State.exit:
                        flag1 = false;
                        break;
                    default:
                        flag1 = false;
                        break;
                }
            }
            Console.ReadKey();
        }
        public int num_of_digit(int num)
        {
            int sum = 0;
            for(int i = 10; i <= num*10; i *= 10, sum++)
            return sum;
        }
    }
}

