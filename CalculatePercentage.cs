using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CalculatePercentage
    {
        static void Main(string[] args)
        {
            int totalSum = 0;
            double percentage;
            Console.WriteLine("Enter your roll no.");
            int rollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the mark of the 3 subjects");
            int[] marks = new int[5];
            for (int i = 1; i <= 3; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());    
            }
            foreach(int mark in marks)
            {
                totalSum += mark;
            }
            Console.WriteLine("The total sum of marks are " + totalSum);
            percentage = ((Convert.ToDouble(totalSum)) / 300)*100;
            Console.WriteLine("The percentage is " + percentage +"%");
            Console.ReadLine();
        }
    }
}
