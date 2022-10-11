using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ThreeDimensialArray
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[2, 2,3]
            {
                { {1, 2 ,3},{4 ,5, 6 } },
                {{7,8,9 },{10,11,12} }
            };
            Console.WriteLine(myArray[0, 1,0]);
            Console.WriteLine(myArray[1, 1, 0]);//10
            Console.WriteLine(myArray[1, 0, 2]);//9
            Console.WriteLine(myArray[0, 1, 1]);

            Console.ReadLine();
        }
    }
}
