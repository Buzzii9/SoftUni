using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + currentNumber;
            }
            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                sumRight = sumRight + currentNumber;
            }
            if (sumLeft == sumRight)

            {
                Console.WriteLine("Yes, sum = {0}", sumRight);
            }
            else
            {
                var result = Math.Abs(sumLeft - sumRight);
                Console.WriteLine("No, diff = {0}", result);
            }
        }
    }
}
