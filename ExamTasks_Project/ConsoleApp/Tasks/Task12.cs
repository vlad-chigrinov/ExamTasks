using System;

namespace ConsoleApp.Tasks
{
    public static class Task12
    {
        public static void Run()
        {
            int[,] intArr =
            {
                {1, 2, 3, 4},
                {1, 5, 3, 4},
                {1, 2, 3, 4},
                {1, 2, 3, -4}
            };
            
            float[,] floatArr =
            {
                {1.1f, 2f, 3f, 4f},
                {1f, 5.9f, 3f, 4f},
                {1f, 2f, 3.4f, 4f},
                {1f, 2f, 3f, -4f}
            };
            
            double[,] doubleArr =
            {
                {1.1f, 2f, 3f, 4f},
                {1f, 5.9f, 3f, 4f},
                {1f, 2f, 3.4f, 4f},
                {1f, 2f, 3f, -4f}
            };
            
            Console.WriteLine(MaxInColumn<int>(1, intArr));
            Console.WriteLine(MaxInColumn<float>(1, floatArr));
            Console.WriteLine(MaxInColumn<double>(2, doubleArr));
        }

        public static T MaxInColumn<T>(int columnNumber, T[,] array) where T : IComparable
        {
            T max = array[0, columnNumber];
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (max.CompareTo(array[i,columnNumber]) < 1)
                {
                    max = array[i, columnNumber];
                }
            }

            return max;
        }
    }
}