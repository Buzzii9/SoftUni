using System;

namespace _02._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //chetem radiani
            double radians = double.Parse(Console.ReadLine());

            //preobrazuvame radiani kum degrees
            //formula: gradus = radian * 180/pi
            double degrees = radians * 180 / Math.PI;

            //otpechtvame rezultata
            Console.WriteLine(degrees);
        }
    }
}
