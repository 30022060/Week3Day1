using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Fruit calculator machine.\nApples / Bananas / Pears");
            string fruit = Console.ReadLine().ToLower();
            string answer;
            switch (fruit)

            {
                case "apples":
                    answer = "Apples are $2.50 a kilogram";
                    break;

                case "bananas":
                    answer = "Bananas are $4.50 a kilogram";
                    break;

                case "pears":
                    answer = "Pears are $3.00 a kilogram";
                    break;
                default:
                    answer = "That was not a fruit.";
                    break;

            }
            Console.WriteLine(answer);
            Console.ReadLine();
        
        }
    }
}
