using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SortArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of elements");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            int[] newArr = new int[] {};
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Array.Copy(arr, newArr,arr.Length);
            Console.WriteLine("The sorted array is");

            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nAnother way to sort array");
            Array.Sort(arr);
            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
