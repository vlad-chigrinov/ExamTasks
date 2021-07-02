using System;

namespace ConsoleApp.Tasks
{
    public static class Task1
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

            int intMax = MaxMainDiagonalValue<int>(intArr);
            Console.WriteLine($"Int max: {intMax}");

            float floatMax = MaxMainDiagonalValue<float>(floatArr);
            Console.WriteLine($"Float max: {floatMax}");

            double doubleMax = MaxMainDiagonalValue<double>(doubleArr);
            Console.WriteLine($"Double max: {doubleMax}");
        }
        
        private static T MaxMainDiagonalValue<T>(T[,] A) where T : IComparable
        {
            T max = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max.CompareTo(A[i, j]) < 0)
                    {
                        max = A[i, j];
                    }
                }
            }

            return max;
        }
    }
}