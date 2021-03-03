using System;

namespace J1_Speeds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter speed limit:");
            int Speed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter recorded speed of car:");
            int CarSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Solve(Speed, CarSpeed));

        }
        static string Solve(int Speed, int CarSpeed)
        {
            int changeSpeed = CarSpeed - Speed;
            if (changeSpeed <= 0)
            {
                return "Congratualations, you are within the speed limit"; 
            }
            else if (changeSpeed <= 20)
            {
                return "Your are speeding and your fine is $100";
            }
            else if (changeSpeed >= 20 && changeSpeed <= 30)
            {
                return "You are speeding and your fine is $270";
            }
            else
            {
                return "You are speeding and your fine is $500";
            }
        }
    }
}
