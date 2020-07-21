using System;

namespace Lab2_RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double roomLength;
            double roomWidth;
            double roomHeight;
            string continueMeasuring;

            Console.WriteLine("Hello! Welcome to the Grand Circus room measuring tool!");
            Console.WriteLine("Would you like to measure a room? Enter y or n.");
            continueMeasuring = Console.ReadLine();

            while(continueMeasuring == "y")
            {

                Console.WriteLine("What is the length of the room in feet?");
                roomLength = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the width of the room in feet?");
                roomWidth = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the height of the room in feet?");
                roomHeight = double.Parse(Console.ReadLine());

                double roomArea = roomLength * roomWidth;
                double roomPerimeter = 2 * (roomLength + roomWidth);
                double roomVolume = roomLength * roomWidth * roomHeight;
                double surfaceArea = (2 * (roomLength * roomWidth)) + (2 * (roomWidth * roomHeight)) + (2 * (roomLength * roomHeight));

                Console.WriteLine("The area of the room is: " + roomArea + " feet");
                Console.WriteLine("The Perimeter of the room is: " + roomPerimeter + " feet");
                Console.WriteLine("The volume of the room is: " + roomVolume + " feet");
                Console.WriteLine("The surface area of the room is: " + surfaceArea + " feet");

                Console.WriteLine("Would you like to measure another room? (y/n)");
                continueMeasuring = Console.ReadLine();

                while(continueMeasuring != "y" && continueMeasuring != "n")
                {
                    Console.WriteLine("Please enter y or n" + continueMeasuring);
                    continueMeasuring = Console.ReadLine();
                }
            }
        }
    }
}
