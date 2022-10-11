using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[] { 1, 2, 3, 4, 5 };
            foreach (int num in myarray)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("press enter");
            Console.ReadLine();
        }
    }
}
