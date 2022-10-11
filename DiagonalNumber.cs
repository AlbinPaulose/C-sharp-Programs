using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DiagonalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of rows");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no. of columns");
            int column = Convert.ToInt32(Console.ReadLine());
            int sumOfDiagonal = 0;

            while(row != column)
            {
                Console.WriteLine("The row and column should be equal");
                Console.WriteLine("Please enter the no. of columns again");
                column = Convert.ToInt32(Console.ReadLine());
            }
            int[,] arr = new int[row,column];
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    Console.WriteLine("Enter the number");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The Entered array is");
            for(int i = 0; i < row; i++)
            {
                for(int j=0; j < column; j++)
                {
                    Console.Write(" {0}",arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.Write("First Diagonal numbers are: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if(i == j)
                    {
                        Console.Write(arr[i,j]+" ");
                        sumOfDiagonal += arr[i,j];
                    }
                }
            }
            Console.Write("\nSecond Diagonal numbers are: ");

            for (int i = 0; i < row; i++)
            {
                column = column - 1;
                for(int k = 0; k < row; k++)
                {
                    if(k == column)
                    {
                        Console.Write(arr[i, k]+" ");
                        sumOfDiagonal += arr[i, k];

                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("\nThe sum of diagonal numbers are: {0}",sumOfDiagonal);

            Console.ReadLine();


        }
    }
}
