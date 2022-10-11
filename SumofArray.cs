using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SumofArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of elements");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            int totalSum = 0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                totalSum += arr[i];    
            }
            Console.WriteLine("The sum of numbers is {0}", totalSum);
            Console.ReadLine();


        }

    }
}
