using System;

namespace MentorMateTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            if (n <= 2 || n >= 10000)
            {
                Console.WriteLine("N out of range");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine("N should be odd");
            }
            else
            {
                string[,] arr = new string[n + 1, n * 10];
                EmptyLogo(arr, arr.GetUpperBound(0), arr.GetUpperBound(1));
                CreatingLogo(arr, arr.GetUpperBound(0), arr.GetUpperBound(1));
                DuplicatingLogo(arr, arr.GetUpperBound(0), arr.GetUpperBound(1));
                Output(arr);
                Console.WriteLine();
            }
        }
        static void EmptyLogo(string[,] arr, int row, int column)
        {
            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= column; j++)
                {
                    arr[i, j] = "- ";
                }
            }
        }
        static void CreatingLogo(string[,] arr, int row, int column)
        {
            int number = 0;
            for (int j = 0; j < column/2; j++)
            {
                if (number == row)
                {
                    for (int k = j; k < j + row; k++)
                    {
                        arr[0, k] = "* ";

                        for (int i = 1; i <= row; i++)
                        {
                            arr[i, k - i] = "* ";
                            arr[i, k + i] = "* ";
                        }
                    }
                    j += row-1;
                    number = 0;
                }
                else
                {
                    number++;
                }
            }
        }      
        static void DuplicatingLogo(string[,] arr,int row, int column)
        {
            for (int i = 0; i <= row; i++)
            {
                int m = 0;
                for (int k = column/2+1; k <= column; k++)
                {
                    arr[i, k] = arr[i, m];
                    m++;
                }
            }
        }
        static void Output(string[,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

