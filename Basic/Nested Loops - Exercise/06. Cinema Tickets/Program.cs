using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double counterStandard = 0;
            double counterStuden = 0;
            double counterKid = 0;
            double percent = 0;
            double sum = 0;
           
            double counterTickets = 0; 
            double freeSpaces = 0;

            double counterStandard2 = 0;
            double counterStuden2 = 0;
            double counterKid2 = 0;

            while (movie != "Finish")
            {
                freeSpaces = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();

                while (type != "End")
                {
                    if (type == "standard")
                    {
                        counterStandard++;
                        counterStandard2++;
                    }
                    else if (type == "student")
                    {
                        counterStuden++;
                        counterStuden2++;
                    }
                    else if (type == "kid")
                    {
                        counterKid++;
                        counterKid2++;
                    }

                    sum = counterStandard + counterKid + counterStuden;
                    counterTickets++; 

                    if (sum >= freeSpaces)
                    {
                        break;
                    }

                    type = Console.ReadLine();
                }

                percent = 100 * sum / freeSpaces;

                Console.WriteLine($"{movie} - {percent:f2}% full.");

                counterStandard = 0;
                counterStuden = 0;
                counterKid = 0;
                sum = 0;

                movie = Console.ReadLine();
            }

           

            double studProz = 100 * counterStuden2 / counterTickets;
            double sandProz = 100 * counterStandard2 / counterTickets;
            double kidProz = 100 * counterKid2 / counterTickets;

            Console.WriteLine($"Total tickets: {counterTickets}");
            Console.WriteLine($"{studProz:f2}% student tickets.");
            Console.WriteLine($"{sandProz:f2}% standard tickets.");
            Console.WriteLine($"{kidProz:f2}% kids tickets.");
        }
    }
}
