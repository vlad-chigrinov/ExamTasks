using System;
using System.Collections;
using System.Collections.Generic;

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
            private string name;
            private string secondName;
            private DateTime birthDate;

            public string Name { get { return name; } }
            public string SecondName { get { return secondName; } }
            public DateTime BirthDate { get { return birthDate; } }
            public int BirthDateYear { get { return birthDate.Year; }
                set
                {
                    birthDate = new DateTime(value, birthDate.Month, birthDate.Day);
                    GC.Collect();
                }
            }

            public Person()
            {
                name = "Danny";
                secondName = "Jonson";
                birthDate = new DateTime(2000, 1, 1);
            }

            public Person(string Name, string SecondName, DateTime BirthDate)
            {
                name = Name;
                secondName = SecondName;
                birthDate = BirthDate;
            }

            public override string ToString()
            {
                return $"{Name};{SecondName};{BirthDate}";
            }

            public virtual string ToShortString()
            {
                return Name;
            }

            public int CompareTo(object obj)
            {
                try
                {
                    Person pers = obj as Person;
                    if (pers != null)
                        return Name.CompareTo(pers.Name);
                    else
                        throw new Exception("Invalid comparation");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                GC.Collect();
                return -2;
            }

            public int Compare(object x, object y)
            {                
                if ((x as Person).birthDate.CompareTo((y as Person).birthDate) != 0)
                {
                    return (x as Person).birthDate.CompareTo((y as Person).birthDate);
                }
                else if ((x as Person).birthDate.CompareTo((y as Person).birthDate) != 0)
                {
                    return (x as Person).birthDate.CompareTo((y as Person).birthDate);
                }
                else if ((x as Person).birthDate.CompareTo((y as Person).birthDate) != 0)
                {
                    return (x as Person).birthDate.CompareTo((y as Person).birthDate);
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
