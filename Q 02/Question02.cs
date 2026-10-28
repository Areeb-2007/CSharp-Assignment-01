using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question__02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassID: 120703 | Student ID: 66518 | Name: Areeb Khan | Submission Date: 29-10-2026");
            Console.WriteLine("");

            double amount, discountPercent, discount, finalAmount;

            Console.WriteLine("Enter Your Purchase Amount");
            amount = double.Parse(Console.ReadLine());

            if (amount >= 5000)
            {
                discountPercent = 20;
            }

            else if (amount >= 2000)
            {
                discountPercent = 10;
            }

            else
            {
                discountPercent = 0;
            }

            discount = amount * discountPercent / 100;
            finalAmount = amount - discount;

            Console.WriteLine("Discount Percentage: " + discountPercent);
            Console.WriteLine("Discount Amount: " + discount);
            Console.WriteLine("Final Amount: " + finalAmount);

            Console.ReadKey();
        }
        
    }
}
