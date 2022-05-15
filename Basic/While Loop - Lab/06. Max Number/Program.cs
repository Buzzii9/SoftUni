using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.MinValue;
            string input = Console.ReadLine();  

            while (input != "Stop")
            {
                int n = int.Parse(input);

                if (n > number)
                {
                    number = n;
                }

                input = Console.ReadLine(); 
            }


            Console.WriteLine(number);
        }
    }
}
