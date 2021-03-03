using System;

namespace Assignment2pt3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grade Evaluator");
            Console.Write("What is your first subject grade: ");
            double Grade1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your secound subject grade: ");
            double Grade2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your third subject grade: ");
            double Grade3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your forth subject grade: ");
            double Grade4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Grader(Grade1,Grade2,Grade3,Grade4));
        }
        static string Grader(double Grade1, double Grade2, double Grade3, double Grade4)
        {
            double avg = (Grade1 + Grade2 + Grade3 + Grade4) / 4;
            if (avg>= 80)
            {
                return "Keep up thegood work.";
            }
            else if (avg>= 60 && avg<80)
            {
                return "Satisfactory, but there is room for improvement.";
            }
            else
            {
                return "Greater effort is needed.";
            }
        }
    }
}
