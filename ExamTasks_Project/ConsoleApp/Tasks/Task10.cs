using System;
using System.Collections.Generic;

namespace ConsoleApp.Tasks
{
    public static class Task10
    {
        public static void Run()
        {
            int[] intArr = {1, 2, 7, 4, 5, 6};
            float[] floatArr = {1.7f, 2.2f, 7.9f, 4.2f, 5.5f, 6.9f};
            double[] doubleArr = {1.7, 2.3, 7.5, 4.7, 5.3, 6.8};
            
            Console.WriteLine(nameof(intArr));
            PrintArray(ElementsAfterMax<int>(intArr));
            Console.WriteLine(nameof(floatArr));
            PrintArray(ElementsAfterMax<float>(floatArr));
            Console.WriteLine(nameof(doubleArr));
            PrintArray(ElementsAfterMax<double>(doubleArr));
        }
        
        static void PrintArray<T>(T[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        
        static T[] ElementsAfterMax<T>(T[] arr) where T : IComparable
        {
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[maxIndex].CompareTo(arr[i]) < 0)
                {
                    maxIndex = i;
                }
            }

            List<T> elements = new List<T>();

            for (int i = maxIndex + 1; i < arr.Length; i++)
            {
                elements.Add(arr[i]);
            }

            return elements.ToArray();
        }
    }
}