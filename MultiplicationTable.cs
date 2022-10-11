using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args);
            Console.WriteLine("Enter a number to view multiplication table");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i+"*"+num+ " = " + i*num);
            }
            Console.ReadLine();
        }
    }
}
