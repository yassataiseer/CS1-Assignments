using System;

namespace Assignment2pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rogers Game Centre");
            Console.Write("How much change do you have? $");
            double change = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Calculate(change));
        }
        static string Calculate(double change)
        {
            if (change >= 2.50)
            {
                return "Grab a hot dog.";
            }
            else
            {
                return "Enjoy the game!";
            }
        }
    }
}
