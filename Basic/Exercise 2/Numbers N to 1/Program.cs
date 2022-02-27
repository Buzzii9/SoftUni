using System;

namespace Numbers_N_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //n=10
            //i=9

            for (int i = 1; i <= n ; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
