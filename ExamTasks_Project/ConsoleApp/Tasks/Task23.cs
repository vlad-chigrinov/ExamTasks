using System;
using System.IO;
using System.Text;

namespace ConsoleApp.Tasks
{
    public static class Task23
    {
        public static void Run()
        {
            int[,] arr = new int[10, 10];
            var rnd = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                }
            }
            
            Console.WriteLine($"Количество отрицательных элементов: {NegativeCount(arr)}");
        }

        private static int NegativeCount(int[,] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}