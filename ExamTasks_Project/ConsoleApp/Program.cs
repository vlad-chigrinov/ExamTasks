using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RunFunctionWithName(Task1.Run);

            RunFunctionWithName(Task2.Run);

            RunFunctionWithName(Task3.Run);

            RunFunctionWithName(Task4.Run);

            RunFunctionWithName(Task5.Run);

            RunFunctionWithName(Task6.Run);

            RunFunctionWithName(Task7.Run);

            RunFunctionWithName(Task8.Run);

            RunFunctionWithName(Task9.Run);

            RunFunctionWithName(Task10.Run);

            RunFunctionWithName(Task12.Run);

            RunFunctionWithName(Task13.Run);

            RunFunctionWithName(Task14.Run);

            RunFunctionWithName(Task15.Run);

            RunFunctionWithName(Task18.Run);

            RunFunctionWithName(Task21.Run);

            RunFunctionWithName(Task22.Run);

            RunFunctionWithName(Task23.Run);
            
            RunFunctionWithName(Task26.Run);
            
            RunFunctionWithName(Task27.Run);
            
            RunFunctionWithName(Task28.Run);
            
            RunFunctionWithName(Task29.Run);
            
            Console.ReadLine();
        }

        static void RunFunctionWithName(Action action) //чисто для красивого вывода в консоль
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n#{action.Method.ReflectedType?.ToString()} - {action.Method.Name}\n");
            Console.ForegroundColor = defaultColor;

            action.Invoke();
        }
    }
}