using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class LargestNumber
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            
            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine(num1 + " is the greatest number ");
                }
                else
                {
                    Console.WriteLine(num3 + " is the greatest number ");
                }
            }
            else if (num2 > num3) 
            {
                Console.WriteLine(num2 + " is the geatest number");

            }
            else
            {
                Console.WriteLine(num3 + " is the greatest number");
            }

            Console.ReadLine();
        }
    }
}
