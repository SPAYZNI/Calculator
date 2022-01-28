using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //User Input

                Console.WriteLine("Write a number");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Write an operator(+, -, *, /)");
                string op = Console.ReadLine();

                Console.WriteLine("Write another number");
                double b = Convert.ToDouble(Console.ReadLine());

                //Calculation

                if (op == "+")
                {
                    Console.WriteLine($"Answer is {a + b}! Press any button to close the Calculator");
                }
                else if (op == "-")
                {
                    Console.WriteLine($"Answer is {a - b}! Press any button to close the Calculator");
                }
                else if (op == "*")
                {
                    Console.WriteLine($"Answer is {a * b}! Press any button to close the Calculator");
                }
                else if (op == "/")
                {
                    Console.WriteLine($"Answer is {a / b}! Press any button to close the Calculator");

                }
                else
                {
                    Console.WriteLine("Operator not Valid, press any button to close calculator");
                }

            } catch (FormatException e)
            {
                Console.WriteLine($"Error, {e.Message} Try again");
            }

            //End
            Console.ReadKey();
        }
    }
}

//An basic Calculator, coded by spayzni