using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_9209_6071
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Welcome9209();
            Welcome6071();
            Console.ReadKey();
        }

        static partial void Welcome6071();

        private static void Welcome9209()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("{0} , welcome to my first console application", name);
        }
    }
}
