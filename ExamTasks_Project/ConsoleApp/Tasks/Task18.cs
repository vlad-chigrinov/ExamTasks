using System;
using System.IO;
using System.Text;

namespace ConsoleApp.Tasks
{
    public static class Task18
    {
        public static void Run()
        {
            Console.WriteLine("Введите количество строк:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, m];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Введите [{i},{j}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            var minIndex = MinIndex(arr);
            
            Console.WriteLine($"Минимальный элемент: {arr[minIndex.i, minIndex.j]} [{minIndex.i},{minIndex.j}]");
        }

        private static (int i, int j) MinIndex(int[,] arr)
        {
            int iMinIndex, jMinIndex;
            iMinIndex = jMinIndex = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[iMinIndex, jMinIndex])
                    {
                        iMinIndex = i;
                        jMinIndex = j;
                    }
                }
            }

            return (iMinIndex, jMinIndex);
        }
    }
}