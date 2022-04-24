using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // Четем от конзолата
            string ticketType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            // izchislqvame
            double income = row * col;
            //проверяваме типа на билетите
            if (ticketType == "Premiere")
            {
                income = income * 12.00;
            }
            else if (ticketType == "Normal")
            {
                income = income * 7.50;
            }
            else
            {
                income = income * 5.00;
            }

            //извеждаме резултат
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
