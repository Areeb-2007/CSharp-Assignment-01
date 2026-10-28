using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassID: 120703 | Student ID: 66518 | Name: Areeb Khan | Submission Date: 29-10-2026");
            Console.WriteLine("");
            
            int day;
            Console.WriteLine("Enter day number (1-7): ");
            day = int.Parse(Console.ReadLine());
            
            switch (day)
            {
                case 1:
                   
                        Console.WriteLine("Monday");
                        break;
                    
                case 2:
                    
                        Console.WriteLine("Tuesday");
                        break;
                    
                case 3:
                    
                        Console.WriteLine("Wednesday");
                        break;
                    
                case 4:
                    
                        Console.WriteLine("Thursday");
                        break;
                    
                case 5:
                    
                        Console.WriteLine("Friday");
                        break;
                    
                case 6:
                    
                        Console.WriteLine("Saturday");
                        break;
                    
                case 7:
                    
                        Console.WriteLine("Sunday");
                        break;
                    
                default:
                    
                        Console.WriteLine("Invalid number");
                        break;
                    
            }
            Console.ReadKey(); 
           
        }
    }
}