using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ArrayForloop
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5] {1,2,3,4,5};
            foreach(int i in myArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
