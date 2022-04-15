using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            double area = 0;

            if (inp == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }

            else if (inp == "rectangle")
            {
                double w = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = w * h;
            }

            else if (inp == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }

            else if (inp == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b / 2;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
