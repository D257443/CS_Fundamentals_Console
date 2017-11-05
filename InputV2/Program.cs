using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;

            do
            {
                Console.WriteLine("Please enter a number:");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number));
            if (number <= 100) {
                Environment.Exit(1);
            }

            Console.WriteLine("{0}", number);

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
