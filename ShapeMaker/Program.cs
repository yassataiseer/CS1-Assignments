using System;

namespace ShapeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a triangle: ");
            string Design = "";
            for (int i = 0; i < 10; i++)
            {
                Design += "*";
                Console.WriteLine(Design);
            }
            Console.WriteLine("This is a square: ");
            string SquareDesign = "";
            for (int r = 0; r<5;r++)
            {
                for (int j = 0; j<5;j++)
                {
                    SquareDesign += "*";
                }
                Console.WriteLine(SquareDesign);
                SquareDesign = "";
            }

            Console.WriteLine("This is a rectangle: ");
            string Rectangle = "";
            for (int length = 0; length < 6; length++)
            {
                for (int width = 0; width < 3; width++)
                {
                    Rectangle += "*";
                }
                Console.WriteLine(Rectangle);
                Rectangle = "";
            }
        }
    }
}
