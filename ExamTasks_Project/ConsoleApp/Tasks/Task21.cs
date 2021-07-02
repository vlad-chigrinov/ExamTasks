using System;
using System.IO;
using System.Text;

namespace ConsoleApp.Tasks
{
    public static class Task21
    {
        public static void Run()
        {
            Console.WriteLine(NOD(20, 5));
            Console.WriteLine(NOD(5, 20));
            Console.WriteLine(NOD(12, 4));
            Console.WriteLine(NOD(10, 4));
        }

        private static int NOD(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return NOD(b, a % b);
            }
        }
    }
}