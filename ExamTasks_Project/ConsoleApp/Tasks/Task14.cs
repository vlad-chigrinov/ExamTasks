using System;
using System.IO;

namespace ConsoleApp.Tasks
{
    public static class Task14
    {
        public static void Run()
        {
            int[,] intArr =
            {
                {1, 2, 3, 4},
                {1, 5, 3, 4},
                {1, 2, 3, 4},
                {1, 2, 3, 4}
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
                {1f, 2f, 3f, 4f}
            };

            int intMax = MinMainDiagonalValue<int>(intArr);
            Console.WriteLine($"Int min: {intMax}");

            float floatMax = MinMainDiagonalValue<float>(floatArr);
            Console.WriteLine($"Float min: {floatMax}");

            double doubleMax = MinMainDiagonalValue<double>(doubleArr);
            Console.WriteLine($"Double min: {doubleMax}");
        }
        
        private static T MinMainDiagonalValue<T>(T[,] A) where T : IComparable
        {
            T max = A[0, 0];
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (max.CompareTo(A[i, i]) > 0)
                {
                    max = A[i, i];
                }
            }

            return max;
        }
    }
}