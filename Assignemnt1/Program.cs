using System;

namespace Assignemnt1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Enter a then press ENTER:");
            a = Convert.ToDouble(Console.ReadLine());
            double b;
            Console.Write("Enter b then press ENTER:");
            b = Convert.ToDouble(Console.ReadLine());
            double c;
            Console.Write("Enter c then press ENTER:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("The Discriminant is: ");
            Console.Write(Solve(a, b, c));
        }
        static double Solve(double a, double b, double c)
        {
            double answer;
            answer = b * b - (4 * a * c);
            return answer;
        }
    }
}
