using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 0) {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
            Console.ReadLine();
        }
    }
}
