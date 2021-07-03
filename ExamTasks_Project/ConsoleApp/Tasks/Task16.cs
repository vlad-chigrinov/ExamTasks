using System;

namespace ConsoleApp.Tasks
{
    class Task16
    {
        public static void Run()
        {
            DATE date1 = new DATE();
            date1.Show();

            DATE date2 = new DATE(1997, 12, 12);
            date2.Show();

            DateTime date = new DateTime().AddYears(1000);
            DATE date3 = new DATE(date);
            date3.Show();

            GC.Collect();
        }

        private class DATE
        {
            private DateTime date;
            public DateTime Date
            {
                get
                {
                    return date;
                }
                set
                {
                    try
                    {
                        date = Convert.ToDateTime(value);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            public DATE()
            {
                Date = DateTime.Now;
            }
            public DATE(int year, int month, int day)
            {
                Date = new DateTime(year, month, day);
            }
            public DATE(DateTime date)
            {
                Date = date;
            }

            public void Show()
            {
                Console.WriteLine($"{date.Day}.{date.Month}.{date.Year} г.\n");
            }

            public void SetDay()
            {
                Console.Write("Enter the day you want to set: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Date = new DateTime(Date.Year, Date.Month, day);
                GC.Collect();
            }

            public void SetMonth()
            {
                Console.Write("Enter the month you want to set: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Date = new DateTime(Date.Year, month, Date.Day);
                GC.Collect();
            }

            public void SetYear()
            {
                Console.Write("Enter the year you want to set: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Date = new DateTime(year, Date.Month, Date.Day);
                GC.Collect();
            }
        }
    }
}
