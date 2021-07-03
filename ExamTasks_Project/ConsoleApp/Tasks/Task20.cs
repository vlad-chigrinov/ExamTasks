using System;
using System.Collections;

namespace ConsoleApp.Tasks
{
    class Task20
    {
        public static void Run()
        {
            Person p1 = new Person();
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.ToShortString());
            Console.WriteLine();

            Person p2 = new Person("Danny", "Antoha", new DateTime(1999, 01, 02));
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p2.ToShortString());
            Console.WriteLine();
        }

        private class Person : IComparable, IComparer
        {
            private string firstName;
            private string secondName;
            private DateTime birthday;

            public string FirstName
            {
                get => firstName;
                set => firstName = value;
            }

            public string SecondName
            {
                get => secondName;
                set => secondName = value;
            }

            public DateTime Birthday
            {
                get => birthday;
                set => birthday = value;
            }

            public int BirthdayYear
            {
                get => birthday.Year;
                set => birthday = new DateTime(value, birthday.Month, birthday.Day);
            }

            public Person()
            {
                firstName = "Danny";
                secondName = "Jonson";
                birthday = new DateTime(2000, 1, 1);
            }

            public Person(string firstName, string secondName, DateTime birthday)
            {
                firstName = firstName;
                secondName = SecondName;
                birthday = birthday;
            }

            public override string ToString()
            {
                return $"{FirstName} {SecondName}\n" +
                       $"{Birthday.Date.ToShortDateString()}";
            }

            public virtual string ToShortString()
            {
                return $"{FirstName} {SecondName}";
            }

            public int CompareTo(object obj)
            {
                if (obj is Person p1)
                {
                    return FirstName.CompareTo(p1.FirstName);
                }
                else
                {
                    throw new Exception("Invalid compartion");
                    return -2;
                }
            }

            public int Compare(object obj1, object obj2)
            {
                if (obj1 is Person p1 && obj2 is Person p2)
                {
                    return p1.CompareTo(p2);
                }
                else
                {
                    throw new Exception("Invalid compartion");
                    return -2;
                }
            }
        }
    }
}