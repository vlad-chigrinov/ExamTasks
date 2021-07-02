using System;
using System.IO;
using System.Text;

namespace ConsoleApp.Tasks
{
    public static class Task15
    {
        public static void Run()
        {
            var output = ReplaceAllColon("var builder = new StringBuilder(str);");
            Console.WriteLine($"Количество замен: {output.replaceCount}\n" +
                              $"Строка: {output.str}");
        }

        //Файлы с текстом будут в bin/Debug/путь_к_файлу
        private static (string str, int replaceCount) ReplaceAllColon(string str)
        {
            var builder = new StringBuilder(str);
            int counter = 0;
            for (int i = 0; i < builder.Length; i++)
            {
                if (builder[i] == ';')
                {
                    builder[i] = ':';
                    counter++;
                }
            }

            return (builder.ToString(), counter);
        }
    }
}