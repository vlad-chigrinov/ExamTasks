using System;
using System.IO;
using System.Text;

namespace ConsoleApp.Tasks
{
    public static class Task26
    {
        public static void Run()
        {
            string str = "Hello 123 World!";
            Console.WriteLine($"String {str}\n" +
                              $"Digits count {GetDigitsCount(str)}");
        }

        private static int GetDigitsCount(string str)
        {
            int count = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (char.IsDigit(ch))
                {
                    count++;
                }
            }

            return count;
        }
    }
}