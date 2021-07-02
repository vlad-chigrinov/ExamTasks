using System;

namespace ConsoleApp.Tasks
{
    public static class Task3
    {
        enum Operation
        {
            Sum,
            Sub,
            Mul,
            Div
        }
        
        public static void Run()
        {
            double x = 2, y = 2;
            Console.WriteLine($"{x} + {y} = ");
            Calculator(Operation.Sum, ref x, y);
            Console.WriteLine(x);

            x = 7;
            y = 4;
            Console.WriteLine($"{x} - {y} = ");
            Calculator(Operation.Sub, ref x, y);
            Console.WriteLine(x);

            x = 3;
            y = 3;
            Console.WriteLine($"{x} * {y} = ");
            Calculator(Operation.Mul, ref x, y);
            Console.WriteLine(x);

            x = 10;
            y = 2;
            Console.WriteLine($"{x} - {y} = ");
            Calculator(Operation.Div, ref x, y);
            Console.WriteLine(x);
        }
        
        static void Calculator(Operation operation, ref double x, double y)
        {
            switch (operation)
            {
                case Operation.Sum:
                {
                    x += y;
                    break;
                }
                case Operation.Sub:
                {
                    x -= y;
                    break;
                }
                case Operation.Mul:
                {
                    x *= y;
                    break;
                }
                case Operation.Div:
                {
                    x /= y;
                    break;
                }
                default:
                {
                    x = 0;
                    break;
                }
            }
        }
    }
}