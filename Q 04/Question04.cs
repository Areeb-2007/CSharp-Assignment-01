using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Question__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassID: 120703 | Student ID: 66518 | Name: Areeb Khan | Submission Date: 29-10-2026");
            Console.WriteLine("");

            double num1, num2, result;
            char op;

            Console.Write("Enter Your First Number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the Operation(+,-,*,/): ");
            op = char.Parse(Console.ReadLine());

            Console.Write("Enter Your Second Number: ");
            num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result = " + result);
                break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result = " + result);
                break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result = " + result);
                break;

                case '/':
                    result = num1 / num2;
                    Console.WriteLine("Result = " + result);
                break;
                
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadKey();


        }
    }
}
