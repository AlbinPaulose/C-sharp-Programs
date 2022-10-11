using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PatternPyramid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of rows");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for(int i = 1; i <= num; i++)
            {
                for (int k = i; k < num; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" "+"*");
                    
                }
                Console.WriteLine();
                //Console.Write(" ");

            }
            Console.ReadLine();
        }
    }
}
