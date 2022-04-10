using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double liter3 = 0.001;
            int lentgh = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            //calculations
            int volume = lentgh * width * height;
            double volumeLiters = volume * liter3;
            double used = percent / 100;
            double neededliters = volumeLiters * (1 - used);
            //output
            Console.WriteLine(neededliters);
        }
    }
}
