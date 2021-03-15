using System;

namespace ShapeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Width: ");
            int Width = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Length: ");
            int Length = Convert.ToInt16(Console.ReadLine());
            String SquareDesign = "";
            for (int r = 0; r < Width; r++)
            {
                for (int j = 0; j < Length; j++)
                {
                    SquareDesign += "$";
                }
                Console.WriteLine(SquareDesign);
                SquareDesign = "";
            }
        }
    }
}
