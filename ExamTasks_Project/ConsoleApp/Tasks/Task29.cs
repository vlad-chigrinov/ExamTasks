using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp.Tasks
{
    public static class Task29
    {
        public static void Run()
        {
            string folderPath = "./Tasks/Task29_Files/";
            char startChar = 'a';
            Console.WriteLine($"Количество файлов в папке '{folderPath}'," +
                              $"которые начинаются с '{startChar}'" +
                              $"= {FilesCountStartWithChar(folderPath, startChar)}");
        }

        private static int FilesCountStartWithChar(string folderPath, char startCh)
        {
            var files = Directory.GetFiles(folderPath);
            return files
                .Select(path => Path.GetFileName(path).ToLower())
                .Count(path => path[0] == startCh);
        }
    }
}