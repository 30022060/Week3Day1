using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guess m favourite bird \nkiwi / parrot / sparrow");

            string bird = Console.ReadLine().ToLower();


            switch (bird)
            {
                case "kiwi":
                case "sparrow":
                    Console.WriteLine("Wrong Answer");
                    break;
                case "parrot":
                    Console.WriteLine("Correct Answer");
                    break;
                default:
                    Console.WriteLine("The hell did you type? The list says \nKiwi / Parrot / Sparrow");
                    break;                   
            }
            Console.ReadLine();


        

        }
    }
}
