using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class OddNaturalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of natural numbers to be printed");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int countOfNaturalNumber = 0;
            int totalSum = 0;
            for(int i = 1; i < num*10; i++)
            {
                if(i % 2 != 0)
                {
                        
                    Console.WriteLine(i);
                    countOfNaturalNumber++;
                    totalSum += i;

                }
                if (countOfNaturalNumber == num) { break; }
            }
            Console.WriteLine("The sum of " + num + " natural numbers is " + totalSum);
            Console.ReadLine();
        }
    }
}
