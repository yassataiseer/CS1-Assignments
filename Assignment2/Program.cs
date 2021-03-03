//Made By Yassa Taiseer
using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CS Assignment 2");
            Console.WriteLine("Press 1 for volume of cube");
            Console.WriteLine("Press 2 for volume of sphere");
            Console.WriteLine("Press 3 for volume of cone");
            Console.WriteLine("Press 4 for volume of cylinder");
            Console.WriteLine("Press any other number to quite");
            int UserInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ProcessInput(UserInput));

        }

        static double ProcessInput(int UserInput)
        {
            if (UserInput == 1)
            {
                return Cube();
            }
            else if (UserInput == 2) {
                return Sphere();
            }
            else if (UserInput == 3)
            {
                return Cone();
            }
            else if(UserInput == 4)
            {
                return Cylinder();
            }
            else
            {
                return 0;
            }
        }


        static double Cube(){
            Console.Write("What is the edge length of the Cube? Enter here:");
            double EdgeLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Your answer is:");
            return EdgeLength *EdgeLength*EdgeLength;
        }
        static double Sphere()
        {
            Console.Write("What is the radius of the sphere? Enter here:");
            double radius = Convert.ToDouble(Console.ReadLine());
            radius = Math.Pow(radius,3);
            double constant = (double)4/3;
            Console.WriteLine("Your answer is:");
            return constant * 3.1416 *radius;
        }
        static double Cone()
        {
            Console.Write("What is the radius of the cone? Enter here:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the hieght of the cone? Enter here:");
            double hieght = Convert.ToDouble(Console.ReadLine());
            radius = Math.Pow(radius,2);
            double constant = (double)1/3;
            Console.WriteLine("Your answer is:");
            return constant * 3.1416 * radius * hieght;
        }
        static double Cylinder()
        {
            Console.Write("What is the radius of the cylinder? Enter here:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the hieght of the cylinder? Enter here:");
            double hieght = Convert.ToDouble(Console.ReadLine());
            radius = Math.Pow(radius,2);
            Console.WriteLine("Your answer is:");
            return 3.1416 * radius * hieght;
        }
    }
}
