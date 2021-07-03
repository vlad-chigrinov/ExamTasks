using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tasks
{
    class Task19
    {
        //Разработайте класс STUDENT,
        //в котором хранится информация о фамилии учащегося, его адрес и средний балл.
        //В классе должны быть реализованы три конструктора,
        //а также методы, позволяющие присваивать значения полям класса и выводить их на экран.
        public static void Run()
        {
            STUDENT student1 = new STUDENT();
            student1.ShowAllInfo();

            STUDENT student2 = new STUDENT("CustomSecondName","Pushkina, 10");
            student1.ShowAllInfo();

            STUDENT student3 = new STUDENT("SecondCustomSecondName", "Kolotushkina, 2", 8.5);
            student1.ShowAllInfo();
        }

        class STUDENT
        {
            public string SecondName { get; set; }
            public string Adress { get; set; }
            public double AverageScore { get; set; }

            public STUDENT()
            {
                SecondName = "StandartName";
                Adress = "StandartAdress";
                AverageScore = 0;
            }
            public STUDENT(string second, string adr)
            {
                SecondName = second;
                Adress = adr;
                AverageScore = 0;
            }
            public STUDENT(string second, string adr, double score)
            {
                SecondName = second;
                Adress = adr;
                AverageScore = score;
            }

            public void ShowAllInfo()
            {
                Console.WriteLine($"Second name: {SecondName}\nAdress : {Adress}\nAverage score : {AverageScore}\n");
            }
        }
    }
}
