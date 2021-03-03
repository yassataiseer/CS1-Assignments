using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i=0; i<=100; i++)
            {
                string answer = "";
                if (i % 3 == 0)
                {
                    answer += "Fizz";
                }
                if (i % 5 == 0)
                {
                    answer += "Buzz";
                }
                if (answer.Length == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(answer);
                }
            }
        }
    }
}