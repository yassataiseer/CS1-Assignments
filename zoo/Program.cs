using System;
using System.Collections;
using System.Linq;
namespace zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solve());
        }
        static string Solve()
        {
            Console.WriteLine("+++++WELCOME+++++");
            double tax = 1.13;
            string[] Setup = Get_data();//We call on function Get_data to get the data from user
            string Weekday = Setup[0];
            string Age = Setup[1];
            //Sort the data
            if (Weekday.ToLower() == "monday")
            {
                return "Unfortunately on Monday we are closed :(";
            }
            // make sure its not monday
            double discount = Day_process(Weekday);//Now we pass it into the Day_process function that checks for discounts
            int Age_int = int.Parse(Age) ;
            double age_cost = Cost_age(Age_int);//Check to see cost of person regarding age
            double final_cost1 = age_cost * discount * tax;
            float final_cost = Convert.ToSingle(final_cost1);
            double discount_percent = discount * 100;
            if (discount_percent >= 100)
            {
                discount_percent = 0;
            }
            string final_answer = string.Format("So your total cost is ${0} as you are {1} years old a ticket costs ${2} you got a discount of %{3}", final_cost,Age,age_cost,discount_percent);
            return final_answer;

        }
        static string[] Get_data()
        {
            Console.Write("What day of the week is it: ");
            string Weekday = Console.ReadLine();
            Console.Write("What is Your age: ");
            string Age = Console.ReadLine();
            string[] user_data = { Weekday, Age };
            return user_data;
        }
        
        static double Day_process(string Day)
        {
            if (Day.ToLower() == "tuesday")
            {
                return 0.70;
            }//On Tuesdays there is a 30% discount so you will only pay for 70% of the price
            else if (Day.ToLower() == "thursday")
            {
                return 0.75;
            }// On thursdays there is a 25% discount so you will only pay for 75% of the original price
            else
            {
                return 1;
            }

        }
        static double Cost_age(int age) {
            if (age < 4)
            {
                return 0;
            }
            else if (age >=4 & age <=12)
            {
                return 8;
            }
            else if(age >= 13 & age <= 19)
            {
                return 12;
            }
            else if (age >= 20 & age <= 60)
            {
                return 16;
            }
            else
            {
                return 10;
            }
        }

    }
}
