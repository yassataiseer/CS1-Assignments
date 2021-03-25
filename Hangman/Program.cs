using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Game());
        }
        static bool Game()
        {
            Console.WriteLine("TESRT");
            string[] country = { "canada", "america","india","china"};
            string[] food = { "pizza", "burgers", "chips","choclates" };
            string[] companies = { "microsoft","apple","amazon","google" };
            string[] categories = { "country","food","companies" };
            string[][] values = {country,food,companies};
            Random rnd = new Random();
            int category_index = rnd.Next(0,4);
            int word_index = rnd.Next(5);
            Console.WriteLine("Welcome To The Hangman Game");
            Console.WriteLine("The category is {0}",categories[category_index]);
            //Console.WriteLine("The word is {0}", values[category_index][word_index]);

            return true;
        }
    }
}
