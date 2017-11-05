using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introductie
            Console.WriteLine("Welcome to the odd and even checker");
            // Vragen om input
            Int64 number;
            string input;
            do
            {
                Console.WriteLine("Please enter a number:");
                input = Console.ReadLine();
            } while (!Int64.TryParse(input, out number));
            // Verwerken van de input
            // Tonen van de output

            if (number %2 == 0)
            {
                Console.WriteLine("The number {0} is even!", number);
            }
            else
            {
                Console.WriteLine("The number {0} is odd!", number);
            }
            // Afsluiten
            Console.WriteLine("Thanks for using the odd and even checker");
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
