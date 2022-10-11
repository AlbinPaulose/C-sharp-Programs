using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hii");
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("Number is divisble by 5 ");
            }
            else
            {
                Console.WriteLine("It's not");
            }
            Console.ReadKey();
            //(num % 5 == 0) ? "It is" : "it's not";
        }
    }
}
