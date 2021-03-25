using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool state = Game();
            if (state == true)
            {
                Console.WriteLine("Congrats Thanks for playing hangman");
            }
            else
            {
                Console.WriteLine("You lost... try again later....");
            }

        }
        static bool Game()
        {
            string[] country = { "canada", "america", "india", "china" };
            string[] food = { "pizza", "burgers", "chips", "choclates" };
            string[] companies = { "microsoft", "apple", "amazon", "google" };
            string[] categories = { "country", "food", "companies" };
            string[][] values = { country, food, companies };
            //string head = " O ";
            //string body = "/ \";
            //string legs = "O->=<";
            Random rnd = new Random();
            int category_index = rnd.Next(0, 4);
            int word_index = rnd.Next(5);
            Console.WriteLine("Welcome To The Hangman Game \n");
            Console.WriteLine("The category is {0} \n", categories[category_index]);
            //Console.WriteLine("The word is {0} \n", values[category_index][word_index]);
            string word = values[category_index][word_index];
            Console.WriteLine("You will 5 lives before the hangman is complete \n");
            Console.WriteLine("Once completed you will lose the game \n");
            int counter = 0;
            List<string> masked_word = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                masked_word.Add("*");
            }
            string[] body = { "O", "-", ">", "=", "<" };
            string build = "";
            var chars_attempted = "";
            while (counter <= 5)
            {

                string combined = string.Join("", masked_word);
                if (word == combined)
                {
                    return true;
                }
                if (5 - counter==0)
                {
                    return false;
                }
                Console.WriteLine("You Currently Have {0} lives left \n", 5 - counter);
                Console.WriteLine("Your word looks like this so far: {0} \n", combined);
                Console.WriteLine("This is how the man currently looks like: "+build);
                Console.Write("Input one character: ");
                char input = Convert.ToChar(Console.ReadLine());
                if (chars_attempted.Contains(input))
                {
                    Console.WriteLine("Oh no you already wrote this letter before... please pick another \n");
                }
                else if (word.Contains(input))
                {
                    Console.WriteLine("Congrats that letter is in the word \n");
                    int data = word.IndexOf(input);
                    List<int> index = Occur(input, word);
                    //masked_word[data] = Convert.ToString(x);
                    //string stuff = string.Join(", ", index);
                    foreach (int location in index) 
                    {
                        masked_word[location] = Convert.ToString(input);
                        chars_attempted += Convert.ToString(input);
                    }
                }

                else
                {
                    Console.WriteLine("That letter does not exist sorry...");
                    build += body[counter];
                    counter++;

                    chars_attempted+= Convert.ToString(input);
                }
                chars_attempted += Convert.ToString(input);
            }
            return false;
        }
        static List<int> Occur (char character, string word){
            List<int> Occurances = new List<int>();
            for (int i = 0; i != word.Length; i++)
            {
                if (word[i] == character)
                {
                    Occurances.Add(i);
                }
            }
            return Occurances;
        }
    }
}