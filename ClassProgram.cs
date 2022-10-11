using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ClassProgram
    {
        class addition
        {
            int a, b;
            public addition()
            {
                a = 1;
                b = 2;   
            }
            static void Main(string[] args)
            {

                addition obj = new addition();
                Console.WriteLine(obj.a);
                Console.WriteLine(obj.b);
                Console.ReadLine();
            }
        }
        

    }
}
