using System;

namespace ConsoleApp.Tasks
{
    public static class Task5
    {
        public static void Run()
        {
            Console.WriteLine("Введите слова через пробел: ");
            string str = Console.ReadLine();

            var strings = str.Split();

            Console.WriteLine("Результат:");

            foreach (var word in strings)
            {
                if (EndCharEqualsStart(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
        
        static bool EndCharEqualsStart(string str)
        {
            // ^1 - это фишка с# 8
            //последний элемент массива
            return str[0] == str[^1];
        }
    }
}