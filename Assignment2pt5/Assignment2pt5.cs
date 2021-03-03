using System;

namespace Assignment2pt5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Yassa's AutoShop where we sell cars and accesories");
            Console.Write("Would you like a car it costs $15000(Y/N)");
            string CarDesicion = Console.ReadLine();
            Console.Write("Would you like a floor mats it costs $100(Y/N)");
            string MattDesicion = Console.ReadLine();
            Console.Write("Would you like a DVD player it costs $500(Y/N)");
            string DVDDesicion = Console.ReadLine();
            Console.Write("Would you like heated seats they only costs $2000(Y/N)");
            string SeatsDesicion = Console.ReadLine();
            Console.Write("Would you like an extended 5-year warrantly it only costs $1500(Y/N)");
            string WarrantyDesicion = Console.ReadLine();
            string[] Headings = {"Base Price ","Floor mats ","Dvd Player ","Heated Seats ","5-Year Extended Warranty ","13% Taxes ","Total Costs "};
            double[] Calculate = Solve(CarDesicion, MattDesicion, DVDDesicion,SeatsDesicion,WarrantyDesicion);
            for (int i = 0; i < 7; i++)
            {
                if (Calculate[i] > 0) {
                    Console.Write(Headings[i]);
                    Console.WriteLine(String.Format("{0:0.00}", Calculate[i]));
                }
                else
                {

                }
            }
        }
        static double[] Solve(string CarDesicion, string MattDesicion, string DVDDesicion, string SeatsDesicion, string WarrantyDesicion)
        {

            double BasePrice = 0;
            double Matts = 0;
            double DvdPlayer = 0;
            double Seats = 0 ;
            double Warranty = 0;
            double Tax = 0;
            double Cost = 0;
            if(CarDesicion == "Y")
            {
                BasePrice += 15000.00;
            }
            if (MattDesicion == "Y")
            {
                Matts += 100.00;
            }

            if (DVDDesicion == "Y")
            {
                DvdPlayer += 500.00;
            }
            if (SeatsDesicion == "Y")
            {
                Seats += 1500.00;
            }

            if (WarrantyDesicion == "Y")
            {
                Warranty += 1500.00;
            }
            Cost = BasePrice+DvdPlayer+Seats+Warranty+Tax+Cost;
            double tax = Cost * 0.13;
            double[] Send_data = {BasePrice, Matts, DvdPlayer,Seats,Warranty,tax,Cost*1.13};
            return Send_data;
        }
    }
}
