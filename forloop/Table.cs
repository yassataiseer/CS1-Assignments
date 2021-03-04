using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Multiplication table generator");
            Console.Write("Input the number of which will generate a multiplication table: ");
            int Table = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                int Answer = i * Table;
                Console.WriteLine("{0}x{1} = {2}",i,Table,Answer);
            }
        }
    }
}
