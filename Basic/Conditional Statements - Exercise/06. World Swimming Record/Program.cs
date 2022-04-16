using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double firstTime = distance * timeForOneMeter;
            double delayDistance = distance / 15.00;
            double delayTime = Math.Floor(delayDistance) * 12.5;
            double realTime = firstTime + delayTime;

            if (realTime >= recordInSeconds)
            {
                realTime -= recordInSeconds;
                Console.WriteLine($"No, he failed! He was { realTime:F2} seconds slower.");

            }
            else if (realTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {realTime:F2} seconds.");
            }

        }
    }
}
