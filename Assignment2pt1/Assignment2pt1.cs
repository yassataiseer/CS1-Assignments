using System;

namespace Assignment2pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Umbrella calculator!!");
            Console.Write("What is the probability of rain: ");
            double Probability = Convert.ToDouble(Console.ReadLine());
            if (TestProbability(Probability) == true)
            {
                Console.WriteLine("Bring your umbrella today");
            }
            else
            {
                Console.Write("Leave your umbrella at home today");
            }
        }
        static bool TestProbability(double Probability)
        {
            if (Probability > 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
