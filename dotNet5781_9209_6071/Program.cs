using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_9209_6071
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Bus> bus_list = new Dictionary<int, Bus>();
            int the_choose;
            bool flag1 = true;
            while (flag1)
            {
                Console.WriteLine("Please select an option from the menu:");
                Console.WriteLine("ADD bus to the list of buses in the company - 1");
                Console.WriteLine("Choosing a bus to travel - 2");
                Console.WriteLine("Do refueling or handling of a bus - 3");
                Console.WriteLine("Viewing the passenger since the last treatment for all the car in the company - 4");
                Console.WriteLine("EXIT - 5");

                the_choose = int.Parse(Console.ReadLine());
                int help_license, help;
                DateTime dt = new DateTime();
                Bus bus123 = new Bus();
                Random r = new Random(DateTime.Now.Millisecond);
                dt = DateTime.Today;// returns today's date

                switch (the_choose)
                {
                    case 1://Requests the number in the new license in order to add it and adds it later He makes sure that no 7 or 8 digits are entered
                        Console.WriteLine("Enter the license number, and the start date of the activity");
                        help_license = int.Parse(Console.ReadLine());
                        Console.WriteLine(dt);
                        bus_list.Add(help_license, bus123);
                        bus_list[help_license].date_set(dt);
                        break;

                    case 2://Checks whether the vehicle is OK either in terms of fuel or in terms of health
                        Console.WriteLine("Enter the license number");
                        help_license = int.Parse(Console.ReadLine());
                        int r1 = r.Next(1, 1200);//Takes a number of miles between 1 and 1200
                        if (!bus_list.ContainsKey(help_license))
                            Console.WriteLine("The bus does not exist in the system");
                        else if (!bus_list[help_license].enough_fuel(r1))
                            Console.WriteLine("the car wont able to drive not enugh fuel");
                        else if (!bus_list[help_license].is_proper(r1, dt))
                            Console.WriteLine("the car wont able to drive it need repair");
                        else
                        {//If a standard uses a function that updates data
                            bus_list[help_license].travel_update(r1);
                        }
                        break;

                    case 3://Gives a choice between repair and fuel
                        Console.WriteLine("Enter the license number");
                        help_license = int.Parse(Console.ReadLine());
                        Console.WriteLine("Choose between treatment and repair: for treatment choose 1 and for repair 2");
                        help = int.Parse(Console.ReadLine());
                        if (help == 1)//Fuel selection and therefore uses the function that fills the fuel
                            if (bus_list.ContainsKey(help_license))
                                bus_list[help_license].refuel();
                            else if (help == 2)
                            {//Selection of correctness and therefore updates the date of treatment for today and the miles from initials
                                dt = DateTime.Today; // returns today's date
                                if (bus_list.ContainsKey(help_license))
                                {
                                    bus_list[help_license].date_set(dt);
                                    bus_list[help_license].set_km_si_se(0);
                                }
                            }
                            else
                                Console.WriteLine("Error");
                        break;

                    case 4://Uses a function that prints all the license digits in them to their digits and miles
                        foreach (var kvp in bus_list)
                            Console.WriteLine("{0}, Value: {1}", kvp.Value.print_digit(kvp.Key), kvp.Value.km_get());
                        break;

                    case 5://exit
                        flag1 = false;
                        break;
                    default:
                        flag1 = false;
                        break;
                }
            }
            Console.ReadKey();
        }


    }
}