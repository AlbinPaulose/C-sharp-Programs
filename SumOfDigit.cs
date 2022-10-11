using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SumOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            //Console.WriteLine(temp);
            while (num > 0)
            {
                int temp = num % 10;
                result += temp;
                num /= 10;
            }
            Console.WriteLine("The sum is "+ result);
            Console.ReadLine();
        }
    }
}
