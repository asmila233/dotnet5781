using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5781_9209_6071
{
    enum State { Add, Choose, GAS, KM, exit };
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
                switch (the_choose)
                {
                    case State.Add:
                        break;
                    case State.Choose:
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
        }
    }
}

