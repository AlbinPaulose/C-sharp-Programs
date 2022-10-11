using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class StringVowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string words = Console.ReadLine();
            char[] vowels = new char[] { 'a', 'e','i','o','u' };
            int vowelsCount = 0;
            foreach(char ch in words)
            {
                foreach(char vowel in vowels)
                {
                    if(ch == vowel)
                    {
                        vowelsCount++;
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("No. of vowels in strings {0}", vowelsCount);

            Console.ReadLine();
        }
    }
}
