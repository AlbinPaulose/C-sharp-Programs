using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class StringSubstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string words = Console.ReadLine();
            Console.WriteLine("Enter a substring to check whether it's in string");
            string subString = Console.ReadLine();

            bool ch = words.Contains(subString);
            if (ch == true)
            {
                Console.WriteLine("The substring '{0}' is present in the string '{1}'",subString,words);
               
            }
            else
                Console.WriteLine("The substring '{0}' is not present in the string '{1}'",subString,words);

            Console.ReadLine();
        }
    }
}
