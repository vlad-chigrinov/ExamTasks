using System;
using System.IO;

namespace ConsoleApp.Tasks
{
    public static class Task13
    {
        public static void Run()
        {
            CopyFile("./Tasks/Task13_Files/Cringe.txt", "./Tasks/Task13_Files/Postirany.txt");
        }

        //Файлы с текстом будут в bin/Debug/путь_к_файлу
        private static void CopyFile(string from, string to)
        {
            var reader = new StreamReader(from);
            string content = reader.ReadToEnd();
            reader.Close();
            
            var writer = new StreamWriter(to);
            writer.Write(content);
            writer.Close();
        }
    }
}