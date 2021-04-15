using System;

namespace oop_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int all_persons = 0, p1, p2, p3;
            double price_pp, aw1, aw2, aw3, price = 0;
            Console.WriteLine("===TOTALLY ACURATE CALCULATOR FOR EXCURSIONS INC===");


            Console.WriteLine("Please, enter price for ONE person:");
            price_pp = double.Parse(Console.ReadLine());


            Console.WriteLine("Please, enter award for FIRST PLACE:");
            aw1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter how many persons won FIRST PLACE:");
            p1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Please, enter award for SECOND PLACE:");
            aw2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter how many persons won SECOND PLACE:");
            p2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Please, enter award for THIRD PLACE:");
            aw3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter how many persons won THIRD PLACE:");
            p3 = int.Parse(Console.ReadLine());


            if (price_pp <= aw1)
            {
                price += aw1 * p1;
                all_persons += p1;
            } else p1 = 0;

            if (price_pp <= aw2)
            {
                price += aw2 * p2;
                all_persons += p2;
            } else p2 = 0;

            if (price_pp <= aw3)
            {
                price += aw3 * p3;
                all_persons += p3;
            } else p3 = 0;


            Console.WriteLine("All students that will go:\nFIRST PLACE: " + p1 + "\nSECOND PLACE: " + p2 + "\nTHIRD PLACE: " + p3);
            
        }
    }
}
