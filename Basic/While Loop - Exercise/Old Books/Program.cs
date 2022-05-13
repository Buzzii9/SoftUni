using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            // zapazvame liubimata kniga na ani
            string favouriteBook = Console.ReadLine();
            int count = 0;

            string input = Console.ReadLine();

            // suzdavame cikul v koito vseki put shte chetem kniga
            // => dokato ne minen prez vsichki knigi (dokato ne poluchim "no more books"

            while (input != "No More Books")
            {
                if (input == favouriteBook)
                {
                    break;
                }

                count++;
                input = Console.ReadLine();
            }

            if (input == favouriteBook)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            if (input == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }


        }
    }
}
