using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chip’s Fast Food Emporium");
            Console.Write("Please enter a burger choice: ");
            int BurgerNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a side order choice: ");
            int SideOrder = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a drink choice: ");
            int DrinkNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a Desert choice: ");
            int DessertNumber = Convert.ToInt32(Console.ReadLine());
            int CalorieCount = Burger(BurgerNumber) + Drinks(DrinkNumber) + SideChoices(SideOrder) + DessertChoice(DessertNumber);
            Console.Write("Your total Calorie count is " + CalorieCount.ToString());
        }

        static int Burger(int BurgerNumber)
        {
            if (BurgerNumber == 1)
            {
                return 461;
            }
            else if (BurgerNumber == 2)
            {
                return 431;
            }
            else if (BurgerNumber == 3)
            {
                return 420;
            }
            else
            {
                return 0;
            }
        }
        static int Drinks(int DrinkNumber)
        {
            if (DrinkNumber == 1)
            {
                return 130;
            }
            else if (DrinkNumber == 2)
            {
                return 160;
            }
            else if (DrinkNumber == 3)
            {
                return 118;
            }
            else
            {
                return 0;
            }
        }
        static int SideChoices(int ChoiceNumber)
        {
            if (ChoiceNumber == 1)
            {
                return 100;
            }
            else if (ChoiceNumber == 2)
            {
                return 57;
            }
            else if (ChoiceNumber == 118)
            {
                return 70;     
            }
            else
            {
                return 0;
            }
        }
        static int DessertChoice(int DessertNumber)
        {
            if (DessertNumber == 1)
            {
                return 167;
            }
            else if (DessertNumber == 2)
            {
                return 266;
            }
            else if (DessertNumber == 2)
            {
                return 75;
            }
            else
            {
                return 0;
            }
        }

      
    }
}
