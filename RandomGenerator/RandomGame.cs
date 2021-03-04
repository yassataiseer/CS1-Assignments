using System;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing game ");
            Random random = new Random();
            int Num = random.Next(1,100);
            Console.WriteLine(Game(Num));
        }

        static string Game(int Number)
        {
            int Guesses = 0;
            int GuessNumber = 0;
            while (GuessNumber!= Number)
            {
                Console.Write("Guess a number between 1-100 ");
                Guesses++;
                GuessNumber = Convert.ToInt32(Console.ReadLine());
                if (GuessNumber>Number)
                {
                    Console.WriteLine("The answer is lower");
                }
                else 
                {
                    Console.WriteLine("The answer is higher");
                }
            }
            string Attempts = Guesses.ToString(); 
            return "Congrats you finally guessed it, it took you "+ Attempts+ " attempts";

        }
    }
}
