using System;

namespace ShapeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Length = Convert.ToInt16(Console.ReadLine());
            int Width = Convert.ToInt16(Console.ReadLine());
            for (int r = 0; r < Length; r++)
            {
                for (int j = 0; j < Width; j++)
                {
                    SquareDesign += "*";
                }
                Console.WriteLine(SquareDesign);
                SquareDesign = "";
            }
        }
    }
}
