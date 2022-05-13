using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var freespace = width * length * height;

            int sum = 0;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int currentCubic = int.Parse(command);
                sum += currentCubic;
                if (freespace < sum)
                {
                    var neededCubics = sum - freespace;
                    Console.WriteLine($"No more free space! You need {neededCubics} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Done")
            {
                var freeCubics = freespace - sum;
                Console.WriteLine($"{freeCubics} Cubic meters left.");
            }
        }
    }
}
