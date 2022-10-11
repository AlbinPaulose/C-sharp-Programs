using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class StringWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string words = Console.ReadLine();
            int lettersCount = 0;
            int wordsCount = 1;
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] == ' ' || words[i]=='\t' || words[i] =='\n')
                {
                    wordsCount++;   
                }
                else
                    lettersCount++;
            }
            Console.WriteLine("No. of words in strings {0}",wordsCount);
            Console.WriteLine("No. of letters in a string {0}",lettersCount);
            Console.ReadLine();
        }
    }
}
