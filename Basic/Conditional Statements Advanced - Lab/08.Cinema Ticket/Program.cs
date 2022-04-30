using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int ticketPrice = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                ticketPrice = 12;
                Console.WriteLine(ticketPrice);
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                ticketPrice = 14;
                Console.WriteLine(ticketPrice);
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                ticketPrice = 16;
                Console.WriteLine(ticketPrice);
            }
        }
    }
}
