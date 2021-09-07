using System;

namespace CircleConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // input in meters
            // Ask  user what conversion to do - micrometers, millimeters, centimeters, decimeters, kilometers
            //output the meters into the desired unit

            Console.Write("Input a length in meters: ");
            double meters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput a conversion unit:");
            Console.WriteLine("type um for micrometer");
            Console.WriteLine("type mm for millimeter");
            Console.WriteLine("type cm for centimeter");
            Console.WriteLine("type dm for decimeter");
            Console.WriteLine("type km for kilometer");
            string userInput = Console.ReadLine();
            double newDistance = 0;

            if (userInput == "um")
            {
                newDistance = meters * 100000;
                Console.WriteLine($"{meters} meters = {newDistance} micrometers");
            }
            else if (userInput == "mm")
            {
                newDistance = meters * 1000;
                Console.WriteLine($"{meters} meters = {newDistance} milimeters");
            }
            else if (userInput == "cm")
            {
                newDistance = meters * 100;
                Console.WriteLine($"{meters} meters = {newDistance} centimeters");
            }
            else if (userInput == "dm")
            {
                newDistance = meters * 10;
                Console.WriteLine($"{meters} meters = {newDistance} decimeters");
            }
            else if (userInput == "km")
            {
                newDistance = meters / 1000;
                Console.WriteLine($"{meters} meters = {newDistance} kilometers");
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }
        }
    }
}
