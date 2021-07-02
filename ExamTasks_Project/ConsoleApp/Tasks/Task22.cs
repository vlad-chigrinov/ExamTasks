using System;
using System.IO;
using System.Text;

namespace ConsoleApp.Tasks
{
    public static class Task22
    {
        public static void Run()
        {
            Console.WriteLine("Введите размер массива:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"Введите [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int minIndex = MinIndex(arr);

            Console.WriteLine($"Максимальный элемент: {arr[minIndex]} [{minIndex}]");
        }

        private static int MinIndex(int[] arr)
        {
            int maxIndex = 0;
            
            int i = 0;
            
            foreach(int x in arr)
            {
                if (x > arr[maxIndex])
                {
                    maxIndex = i;
                }

                i++;
            }

            return maxIndex;
        }
    }
}