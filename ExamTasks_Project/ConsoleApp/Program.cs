using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFunctionWithName(Task1);

            RunFunctionWithName(Task2);

            RunFunctionWithName(Task3);

            RunFunctionWithName(Task5);

            RunFunctionWithName(Task6);

            RunFunctionWithName(Task7);

            RunFunctionWithName(Task8);
            
            RunFunctionWithName(Task9);
            
            RunFunctionWithName(Task10);
        }

        static void RunFunctionWithName(Action action) //чисто для красивого вывода в консоль
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n#{action.Method.Name}\n");
            Console.ForegroundColor = defaultColor;

            action.Invoke();
        }

        static void Task1()
        {
            int[,] intArr =
            {
                {1, 2, 3, 4},
                {1, 5, 3, 4},
                {1, 2, 3, 4},
                {1, 2, 3, -4}
            };
            float[,] floatArr =
            {
                {1.1f, 2f, 3f, 4f},
                {1f, 5.9f, 3f, 4f},
                {1f, 2f, 3.4f, 4f},
                {1f, 2f, 3f, -4f}
            };
            double[,] doubleArr =
            {
                {1.1f, 2f, 3f, 4f},
                {1f, 5.9f, 3f, 4f},
                {1f, 2f, 3.4f, 4f},
                {1f, 2f, 3f, -4f}
            };

            int intMax = Task1_MaxMainDiagonalValue<int>(intArr);
            Console.WriteLine($"Int max: {intMax}");

            float floatMax = Task1_MaxMainDiagonalValue<float>(floatArr);
            Console.WriteLine($"Float max: {floatMax}");

            double doubleMax = Task1_MaxMainDiagonalValue<double>(doubleArr);
            Console.WriteLine($"Double max: {doubleMax}");
        }

        static T Task1_MaxMainDiagonalValue<T>(T[,] A) where T : IComparable
        {
            T max = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max.CompareTo(A[i, j]) < 0)
                    {
                        max = A[i, j];
                    }
                }
            }

            return max;
        }

        static void Task2()
        {
            int[] arr = {8, 4, 7, 3, 7, 4, 7, 4, 7, 6, 3, 1, 0, 9};
            Task2_SortDesc(ref arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Task2_SortDesc(ref int[] Mas)
        {
            //Лайфхак
            //Array.Sort(Mas);

            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = i + 1; j < Mas.Length; j++)
                {
                    if (Mas[i] < Mas[j])
                    {
                        int temp = Mas[i];
                        Mas[i] = Mas[j];
                        Mas[j] = temp;
                    }
                }
            }
        }

        static void Task3()
        {
            double x = 2, y = 2;
            Console.WriteLine($"{x} + {y} = ");
            Task3_Calculator(Task3_OperationType.Sum, ref x, y);
            Console.WriteLine(x);

            x = 7;
            y = 4;
            Console.WriteLine($"{x} - {y} = ");
            Task3_Calculator(Task3_OperationType.Sub, ref x, y);
            Console.WriteLine(x);

            x = 3;
            y = 3;
            Console.WriteLine($"{x} * {y} = ");
            Task3_Calculator(Task3_OperationType.Mul, ref x, y);
            Console.WriteLine(x);

            x = 10;
            y = 2;
            Console.WriteLine($"{x} - {y} = ");
            Task3_Calculator(Task3_OperationType.Div, ref x, y);
            Console.WriteLine(x);
        }

        enum Task3_OperationType
        {
            Sum,
            Sub,
            Mul,
            Div
        }

        static void Task3_Calculator(Task3_OperationType operation, ref double x, double y)
        {
            switch (operation)
            {
                case Task3_OperationType.Sum:
                {
                    x += y;
                    break;
                }
                case Task3_OperationType.Sub:
                {
                    x -= y;
                    break;
                }
                case Task3_OperationType.Mul:
                {
                    x *= y;
                    break;
                }
                case Task3_OperationType.Div:
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

        static void Task5()
        {
            Console.WriteLine("Введите слова через пробел: ");
            string str = Console.ReadLine();

            var strings = str.Split();

            Console.WriteLine("Результат:");

            foreach (var word in strings)
            {
                if (Task5_EndCharEqualsStart(word))
                {
                    Console.WriteLine(word);
                }
            }
        }

        static bool Task5_EndCharEqualsStart(string str)
        {
            // ^1 - это фишка с# 8
            //последний элемент массива
            return str[0] == str[^1];
        }

        static void Task6()
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

        static void Task7()
        {
            double[,] intArr =
            {
                {1, 2, 3, 4},
                {1, 5, 3, 4},
                {1, 2, 3, 4},
                {1, 2, 3, -4}
            };
            double[,] floatArr =
            {
                {1.1f, 2f, 3f, 4f},
                {1f, 5.9f, 3f, 4f},
                {1f, 2f, 3.4f, 4f},
                {1f, 2f, 3f, -4f}
            };
            double[,] doubleArr =
            {
                {1.1f, 2f, 3f, 4f},
                {1f, 5.9f, 3f, 4f},
                {1f, 2f, 3.4f, 4f},
                {1f, 2f, 3f, -4f}
            };

            double k1 = 11;
            double k2 = 11.2f;
            double k3 = 11.2;

            Console.WriteLine($"IntArr, k = {k1}, Result: {Task7_RowsCountLessK(intArr, k1)}");
            Console.WriteLine($"FloatArr, k = {k2}, Result: {Task7_RowsCountLessK(floatArr, k2)}");
            Console.WriteLine($"DoubleArr, k = {k2}, Result: {Task7_RowsCountLessK(doubleArr, k2)}");
        }

        static int Task7_RowsCountLessK(double[,] arr, double k)
        {
            int counter = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double sum = 0;

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }

                if (sum < k)
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Task8()
        {
            int sum = 0;

            Console.WriteLine("Вводите числа через пробел, '0' для выхода!");

            int value = 0;

            do
            {
                value = int.Parse(Console.ReadLine());
                sum += value;
            } while (value != 0);

            Console.WriteLine("Вывод 1: " + sum);
            Console.WriteLine("Вывод 2: {0}", sum);
            Console.WriteLine($"Вывод 3: {sum}");
        }

        static void Task9()
        {
            string str1 = "((dwdwdw)dwdw)";
            string str2 = "((dwdwdw)dwdw))";
            string str3 = "((dwdwdw)dwdw";
            
            Console.WriteLine($"String = {str1} Result = {Task9_BktChecker(str1)}");
            Console.WriteLine($"String = {str2} Result = {Task9_BktChecker(str2)}");
            Console.WriteLine($"String = {str3} Result = {Task9_BktChecker(str3)}");
        }

        static bool Task9_BktChecker(string str)
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

        static void Task10()
        {
            int[] intArr = {1, 2, 7, 4, 5, 6};
            float[] floatArr = {1.7f, 2.2f, 7.9f, 4.2f, 5.5f, 6.9f};
            double[] doubleArr = {1.7, 2.3, 7.5, 4.7, 5.3, 6.8};
            
            Console.WriteLine(nameof(intArr));
            PrintArray(ElementsAfterMax<int>(intArr));
            Console.WriteLine(nameof(floatArr));
            PrintArray(ElementsAfterMax<float>(floatArr));
            Console.WriteLine(nameof(doubleArr));
            PrintArray(ElementsAfterMax<double>(doubleArr));
        }

        static void PrintArray<T>(T[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        
        static T[] ElementsAfterMax<T>(T[] arr) where T : IComparable
        {
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[maxIndex].CompareTo(arr[i]) < 0)
                {
                    maxIndex = i;
                }
            }

            List<T> elements = new List<T>();

            for (int i = maxIndex + 1; i < arr.Length; i++)
            {
                elements.Add(arr[i]);
            }

            return elements.ToArray();
        }
    }
}