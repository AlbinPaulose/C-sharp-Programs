using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CheckTwoIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 != num2)
            {
                Console.WriteLine("They are not equal");
            }
            else
            {
                Console.WriteLine("They are equal");
            }
            Console.ReadLine();
        }
    }
}
