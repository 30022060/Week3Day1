using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please Enter the first Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the second Number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Select one of the following \nAddition = +\nSubtraction = -\nMultiplication = *\nDivision = /");
            string input = Console.ReadLine();

            double result = 0;

            switch (input)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 + num2;
                    break;

                case "/":
                    result = num1 / num2;
                    break;                             
            }
            Console.WriteLine("{0} {1} {2} = {3}", num1, input, num2, result);
            Console.ReadLine();
                
            
        }
    }
}
