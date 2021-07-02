using System;

namespace ConsoleApp.Tasks
{
    public static class Task9
    {
        public static void Run()
        {
            string str1 = "((dwdwdw)dwdw)";
            string str2 = "((dwdwdw)dwdw))";
            string str3 = "((dwdwdw)dwdw";
            
            Console.WriteLine($"String = {str1} Result = {BktChecker(str1)}");
            Console.WriteLine($"String = {str2} Result = {BktChecker(str2)}");
            Console.WriteLine($"String = {str3} Result = {BktChecker(str3)}");
        }
        
        static bool BktChecker(string str)
        {
            int counter = 0;
            foreach (var ch in str.ToCharArray())
            {
                if (ch == '(')
                {
                    counter++;
                }
                else if (ch == ')')
                {
                    counter--;
                }
            }

            return counter == 0;
        }
    }
}