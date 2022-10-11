using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TwoDimensialArray
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 2]
            {
                {1, 2 },{3,4 },{5, 6 }
            };
            Console.WriteLine(myArray[0,0]);
            Console.WriteLine(myArray[0, 1]);
            Console.WriteLine(myArray[1, 0]);
            Console.WriteLine(myArray[1, 1]);
            Console.WriteLine(myArray[2, 0]);
            Console.WriteLine(myArray[2, 1]);

            Console.ReadLine();
        }
    }
}
