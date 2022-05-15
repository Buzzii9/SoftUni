using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxmin = int.MaxValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (num < maxmin)
                {
                    maxmin = num;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(maxmin);
        }
    }
}
