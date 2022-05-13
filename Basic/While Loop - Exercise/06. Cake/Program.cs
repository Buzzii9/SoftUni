using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cake = length * width;
            int pieceРesidue = 0;
            string input = "";
            int counter = 0;



            while (true)
            {

                input = Console.ReadLine();

                if (input != "STOP")
                {
                    counter += int.Parse(input);
                    pieceРesidue = cake - counter;


                    if (counter > cake)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(pieceРesidue)} pieces more.");
                        break;
                    }
                    else if (pieceРesidue == 0)
                    {
                        break;
                    }

                }
                else if (input == "STOP" && pieceРesidue != 0)
                {
                    Console.WriteLine($"{pieceРesidue} pieces are left.");
                    break;
                }



            }
        }
    }
}
