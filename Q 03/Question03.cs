using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question__03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("ClassID: 120703 | Student ID: 66518 | Name: Areeb Khan | Submission Date: 29-10-2026");
            Console.WriteLine("");
           
                int year;

                Console.Write("Enter the year: ");
                year = int.Parse(Console.ReadLine());

                if (year % 400 == 0)
                {
                    Console.WriteLine("Leap year");
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine("Not a leap year");
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine("Leap year");
                }
                else
                {
                    Console.WriteLine("Not a leap year");
                }

            Console.ReadKey();

            
        

    }
}
}
