using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            var timeToCreate = projects * 3;
            Console.WriteLine($"The architect {name} will need {timeToCreate} hours to complete {projects} project/s.");
        }
    }
}
