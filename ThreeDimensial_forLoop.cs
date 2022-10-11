using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ThreeDimensial_forLoop
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[2, 2,3]
            {
                { {1, 2,3 },{4,5 ,6} },
                { {7, 8,9 }, {10, 11,12 } },
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for(int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("arr[{0}][{1}][{2}] = {3}",i,j,k,myArray[i,j,k]);
                    }
                    
                }
            }
            Console.ReadLine();
        }
    }
}
