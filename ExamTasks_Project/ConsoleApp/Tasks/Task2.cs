using System;

namespace ConsoleApp.Tasks
{
    public static class Task2
    {
        public static void Run()
        {
            int[] arr = {8, 4, 7, 3, 7, 4, 7, 4, 7, 6, 3, 1, 0, 9};
            SortDesc(ref arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        
        private static void SortDesc(ref int[] Mas)
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
    }
}