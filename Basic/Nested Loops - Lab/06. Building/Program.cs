using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxFloors = int.Parse(Console.ReadLine());
            int maxRooms = int.Parse(Console.ReadLine());

            for (int floor = maxFloors; floor > 0; floor--)
            {
                string floorString = "";
                for (int room = 0; room < maxRooms; room++)
                {
                    if (floor == maxFloors)
                    {
                        floorString += "L" + floor + room + " ";
                    }
                    else if (floor % 2 == 0)
                    {
                        floorString += "O" + floor + room + " ";
                    }
                    else
                    {
                        floorString += "A" + floor + room + " ";
                    }
                }
                Console.WriteLine(floorString);
            }
            
        }
    }
}
