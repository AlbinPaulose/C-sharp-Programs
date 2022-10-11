using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PatternPyramidNew
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of rows");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= num; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= num; j++)
                {
                    Console.Write(" " + "*");

                }
                Console.WriteLine();
                //Console.Write(" ");

            }
            Console.ReadLine();
        }
    }
}
