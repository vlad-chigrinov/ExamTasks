using System;
using System.IO;
using System.Text;

namespace ConsoleApp.Tasks
{
    public static class Task27
    {
        public static void Run()
        {
            string str = "XXXTentacion";
            Console.WriteLine($"Input string: {str}\n" +
                              $"Output string: {DeleteAllX(str)}");
        }

        private static string DeleteAllX(string str)
        {
            str = str.Replace("X", "");
            return str;
        }
    }
}