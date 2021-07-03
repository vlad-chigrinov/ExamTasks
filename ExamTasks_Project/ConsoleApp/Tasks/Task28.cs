using System;
using System.IO;
using System.Text;

namespace ConsoleApp.Tasks
{
    public static class Task28
    {
        public static void Run()
        {
            string str = "Hello:World";
            Console.WriteLine($"Input string: {str}\n" +
                              $"Output string: {StringAfterColon(str)}");
        }

        private static string StringAfterColon(string str)
        {
            string output = "";

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ':')
                {
                    output = str.Substring(i + 1);
                }
            }

            return output;
        }
    }
}