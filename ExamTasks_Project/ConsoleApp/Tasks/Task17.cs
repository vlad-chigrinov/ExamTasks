using System;

namespace ConsoleApp.Tasks
{
    class Task17
    {
        //Разработать класс с двумя целочисленными полями.
        //Создать конструктор копирования.
        //Разработать метод, заменяющий поля на их последние цифры.
        //Разработать метод вывода полей. Протестировать все методы.

        static public void Run()
        {
            TaskClass task1 = new TaskClass();
            task1.Show();
            task1.First = 228;
            task1.Second = 147;
            task1.Show();
            task1.TrimValues();
            task1.Show();
            Console.WriteLine();

            TaskClass task2 = new TaskClass(ref task1);
            task2.Show();
            task2.First = 156;
            task2.Second = 232;
            task2.Show();
            task2.TrimValues();
            task2.Show();
        }

        private class TaskClass
        {
            public int First { get; set; }
            public int Second { get; set; }

            public TaskClass()
            {
                First = 0;
                Second = 0;
            }

            public TaskClass(ref TaskClass obj)
            {
                First = obj.First;
                Second = obj.Second;
            }

            public void Show()
            {
                Console.WriteLine($"First value = {First}\n");
                Console.WriteLine($"Second value = {Second}\n");
            }

            public void TrimValues()
            {
                First %= 10;
                Second %= 10;
            }
        }
    }
}
