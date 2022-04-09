using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inches");

            var inches = double.Parse(Console.ReadLine());

            var centimeters = inches * 2.54;

            Console.WriteLine("Centimeters");

            Console.WriteLine(centimeters);


        }
    }
}
