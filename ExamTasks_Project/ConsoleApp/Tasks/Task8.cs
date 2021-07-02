using System;

namespace ConsoleApp.Tasks
{
    public static class Task8
    {
        public static void Run()
        {
            int sum = 0;

            Console.WriteLine("Вводите числа через пробел, '0' для выхода!");

            int value = 0;

            do
            {
                value = int.Parse(Console.ReadLine());
                sum += value;
            } while (value != 0);

            Console.WriteLine("Вывод 1: " + sum);
            Console.WriteLine("Вывод 2: {0}", sum);
            Console.WriteLine($"Вывод 3: {sum}");
        }
    }
}