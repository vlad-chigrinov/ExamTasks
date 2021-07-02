using System;

namespace ConsoleApp.Tasks
{
    class Task4
    {
        public static void Run()
        {
            TRAIN train = new TRAIN();
            train.ShowTrainInfo();

            TRAIN train228 = new TRAIN(228);
            train228.ShowTrainInfo();

            TRAIN train1 = new TRAIN(1488, DateTime.Parse("2002.02.11"), "Moscow");
            train1.ShowTrainInfo();
        }

        private class TRAIN
        {
            public int TrainNumber { get; set; }
            public DateTime Time { get; set; }
            public string FinPoint { get; set; }

            public TRAIN()
            {
                TrainNumber = 0;
                Time = DateTime.Now.AddDays(1);
                FinPoint = "Jepa";
            }

            public TRAIN(int numberOfTrain)
            {
                TrainNumber = numberOfTrain;
                Time = DateTime.Now.AddDays(1);
                FinPoint = "Jepa";
            }

            public TRAIN(int numberOfTrain, DateTime timeForRide, string finalPoint)
            {
                TrainNumber = numberOfTrain;
                Time = timeForRide;
                FinPoint = finalPoint;
            }

            public void ShowTrainNumber() => Console.WriteLine($"Train №: {TrainNumber}\n");
            public void ShowTrainFinalPoint() => Console.WriteLine($"Train TimeForRide: {Time}\n");
            public void ShowTrainTimeForRide() => Console.WriteLine($"Train FinPoint: {FinPoint}\n");

            public void ShowTrainInfo()
            {
                ShowTrainNumber();
                ShowTrainFinalPoint();
                ShowTrainTimeForRide();
            }
        }
    }
}