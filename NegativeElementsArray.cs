using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class NegativeElementsArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of elements");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            int[] newArr = { };
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
 
            }
            for(int i = 0; i < num; i++)
            {
                if(arr[i] < 0)
                {
                    newArr = newArr.Concat(new int[] { arr[i] }).ToArray();
                }
            }
            //Console.WriteLine("The length of new array is {0}",newArr.Length);
            if(newArr.Length < 1)
            {
                Console.WriteLine("There is no negative numbers");
            }
            else
            {
                Console.WriteLine("The negative numbers are");
                for(int i = 0; i < newArr.Length; i++)
                {
                    Console.Write(" {0}",newArr[i]);
                }

            }
            Console.ReadLine();


        }
    }
}
