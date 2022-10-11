using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SumofNatural
    {
        static void Main(string[] args)
        {
            int totalSum = 0;
            for(int i = 1; i <= 3; i++)
            {
                totalSum += i;
            }
            Console.WriteLine("The sum of first 10 natural no. is "+totalSum);
            Console.ReadLine();
        }
    }
}
