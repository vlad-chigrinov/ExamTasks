using System;

namespace ConsoleApp.Tasks
{
    class Task25
    {
        static public void Run()
        {
            Triangle tr = new Triangle(5, 4, 3);
            Console.WriteLine($"Is triangle exists?\nAnswer : {tr.IsTriangleExists}\n");
            tr.ShowSidelengths();
            Console.WriteLine(tr.GetPerimetr().ToString());
            Console.WriteLine();
        }

        class Triangle
        {
            private int a;
            private int b;
            private int c;

            public Triangle(int a, int b, int c)
            {
                A = a;
                B = b;
                C = c;
            }

            public int A { get { return a; } set { a = value; } }
            public int B { get { return b; } set { b = value; } }
            public int C { get { return c; } set { c = value; } }
            public bool IsTriangleExists
            {
                get
                {
                    if (a + b > c && a + c > b && b + c > a)
                        return true;
                    else
                        return false;
                }
            }

            public int GetPerimetr()
            {
                return A + B + C;
            }

            public void ShowSidelengths()
            {
                Console.WriteLine($"A : {A}\nB : {B}\nC : {C}\n");
            }
        }
    }
}
