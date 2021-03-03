using System;

namespace Assignment2pt4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Yassa's clothing store!");
            Console.Write("What colour sweater would you like? ");
            String ShirtColour = Console.ReadLine();
            Console.WriteLine(ColorSorter(ShirtColour));
        }

        static string ColorSorter(string ShirtColour)
        {
            if (ShirtColour.ToLower() == "red")
            {
                return Jeans();
            }
            else
            {
                return "You have enough sweaters in this colour";
            }
        }

        static string Jeans()
        {
            Console.WriteLine("This colour will look good on you.");
            Console.WriteLine("How about a pair of jeans to go with the sweater?");
            Console.Write("Pick a color for your jeans: ");
            string JeanColor = Console.ReadLine();
            if (JeanColor.ToLower() == "blue")
            {
                return "This colour doesn’t go well with your complexion.";
            }
            else
            {
                return "Your colour choice is invalid.";
            }
        }
    }
}
