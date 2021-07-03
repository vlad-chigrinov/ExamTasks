using System;

namespace ConsoleApp.Tasks
{
    class Task11
    {
        public static void Run()
        {
            DISTANCE d1 = new DISTANCE();
            d1.ShowDistance();

            DISTANCE d2 = new DISTANCE(425);
            d2.ShowDistance();

            DISTANCE d3 = new DISTANCE(3, 125);
            d3.ShowDistance();
        }

        private class DISTANCE
        {
            public int Meters { get; set; }
            public int centimeters { get; private set; }
            public int Centimeters
            {
                set
                {
                    while (value >= 100)
                    {
                        Meters++;
                        value -= 100;
                    }
                    centimeters = value;
                }
            }

            public DISTANCE()
            {
                Meters = 0;
                Centimeters = 0;
            }

            public DISTANCE(int centimeters)
            {
                Meters = 0;
                Centimeters = centimeters;
            }

            public DISTANCE(int meters, int centimeters)
            {
                this.Meters = meters;
                Centimeters = centimeters;
            }

            public void ShowDistance()
            {
                Console.WriteLine($"{Meters}m {centimeters}cm.\n");
            }

            public void SetCentimeters()
            {
                Console.Write("Enter the distance in centimeters: ");
                Centimeters = Convert.ToInt32(Console.ReadLine());
            }

            public void SetMetres()
            {
                Console.Write("Enter the length in meters: ");
                Meters = Convert.ToInt32(Console.ReadLine());
            }

            public void SetMetresCentimetres()
            {
                Console.WriteLine("Enter the distance in meters and centimeters.");
                Console.Write("Enter meters: ");
                Meters = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter centimeters: ");
                Centimeters = Convert.ToInt32(Console.ReadLine());
            }
        }
    } 
}
