using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_9209_6071
{
    enum State { Add = 1, Choose = 2, GAS = 3, KM = 4, exit = 5 };
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
                dt = DateTime.Today;

                switch (the_choose)
                {
                    case 1:
                        Console.WriteLine("Enter the license number, and the start date of the activity");
                        help_license = int.Parse(Console.ReadLine());
                        Console.WriteLine(dt);
                        bus_list[help_license].date_set(dt);
                        bus_list.Add(help_license, bus123);
                        break;

                    case 2:
                        Console.WriteLine("Enter the license number");
                        help_license = int.Parse(Console.ReadLine());
                        int r1 = r.Next(1, 1200);
                        if (!bus_list.ContainsKey(help_license))
                            Console.WriteLine("The bus does not exist in the system not enugh fuel");
                        else if (!bus_list[help_license].enough_fuel(r1))
                            Console.WriteLine("the car wont able to drive");
                        else if (!bus_list[help_license].is_proper(r1,dt))
                            Console.WriteLine("the car wont able to drive it need repair");
                        else
                        {
                            bus_list[help_license].travel_update(r1);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the license number");
                        help_license = int.Parse(Console.ReadLine());
                        Console.WriteLine("Choose between treatment and repair: for treatment choose 1 and for repair 2");
                        help = int.Parse(Console.ReadLine());
                        if (help == 1)
                            if (bus_list.ContainsKey(help_license))
                                bus_list[help_license].refuel();
                            else if (help == 2)
                            {
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

                    case 4:
                        foreach (var kvp in bus_list)
                            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value.km_get());
                        break;

                    case 5:
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
            for (int i = 10; i <= num * 10; i *= 10, sum++) ;
                return sum;
        }
        public void print_digit(int num)
        {
            int[] digit_7 = new int[7];
            int[] digit_8 = new int[8];
            if (num_of_digit(num) == 7)
            {
                for (int i = 10, j = 0; j < 7; i *= 10, j++)
                    digit_7[j] = (num % i) / (i / 10);
                Console.WriteLine("{0}, {1} - {2}, {3}, {4} - {5}, {6}", digit_7[0], digit_7[1], digit_7[2], digit_7[3], digit_7[4], digit_7[5], digit_7[6]);

            }
            else if (num_of_digit(num) == 8)
            {
                for (int i = 10, j = 0; j < 8; i *= 10, j++)
                    digit_8[j] = (num % i) / (i / 10);
                Console.WriteLine("{0}, {1}, {2} - {3}, {4} - {5}, {6}, {7}", digit_8[0], digit_8[1], digit_8[2], digit_8[3], digit_8[4], digit_8[5], digit_8[6], digit_8[7]);
            }
            else
                Console.WriteLine("Error");

        }
    }
}

