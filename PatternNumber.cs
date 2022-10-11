using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PatternNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of rows");
            Console.WriteLine();
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
