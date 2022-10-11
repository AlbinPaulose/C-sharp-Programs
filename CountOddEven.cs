using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CountOddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of elements");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            int even = 0; 
            int odd = 0;
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if(arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                    odd += 1;
            }
            Console.WriteLine("The no. of odd elements is {0}", odd);
            Console.WriteLine("The no. of even numbers is {0}",even);
            Console.ReadLine();


        }
    }
}
