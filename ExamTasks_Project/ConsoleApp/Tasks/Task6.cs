using System;

namespace ConsoleApp.Tasks
{
    public static class Task6
    {
        public static void Run()
        {
            Console.WriteLine("Введите число:");
            string number = Console.ReadLine();

            Console.WriteLine("Введите 'сумма' или 'произведение':");
            string type = "";
            do
            {
                type = Console.ReadLine();
            } while (type != "сумма" && type != "произведение");

            char[] chars = number.ToCharArray();

            int output = 0;

            foreach (var ch in chars)
            {
                if (char.IsDigit(ch))
                {
                    int num = int.Parse(ch.ToString());

                    if (type == "сумма")
                    {
                        output += num;
                    }
                    else
                    {
                        if (output == 0)
                        {
                            output = 1;
                        }

                        output *= num;
                    }
                }
            }

            Console.WriteLine($"Рузультат: {output}");
        }
    }
}