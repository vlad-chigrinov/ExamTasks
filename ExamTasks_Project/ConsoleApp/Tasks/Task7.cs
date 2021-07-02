using System;

namespace ConsoleApp.Tasks
{
    public static class Task7
    {
        public static void Run()
        {
            double[,] intArr =
            {
                {1, 2, 3, 4},
                {1, 5, 3, 4},
                {1, 2, 3, 4},
                {1, 2, 3, -4}
            };
            double[,] floatArr =
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

            double k1 = 11;
            double k2 = 11.2f;
            double k3 = 11.2;

            Console.WriteLine($"IntArr, k = {k1}, Result: {RowsCountLessK(intArr, k1)}");
            Console.WriteLine($"FloatArr, k = {k2}, Result: {RowsCountLessK(floatArr, k2)}");
            Console.WriteLine($"DoubleArr, k = {k2}, Result: {RowsCountLessK(doubleArr, k2)}");
        }
        
        static int RowsCountLessK(double[,] arr, double k)
        {
            int counter = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double sum = 0;

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }

                if (sum < k)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}