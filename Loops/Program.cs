using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // For-loop
            for (Int64 i = 0; i < 100000000000000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0}", i);
            }
            /* Wanneer?
             * Start
             * Einde
             * Stapgrootte bekend
             * Hoe vaak er gelust moet worden is bekend */
            
            // While-loop
            string loginName = "S";
            while (loginName != "Sietse")
            {
                loginName = "Iets anders";
            }
            /* Wanneer?
             * Eerst: Check! Mogen we lussen?
             * We weten niet hoe vaak we mogen loopen!
             * De stapgrootte weten we niet */

            // Do ... While-loop
            bool isNumber;
            do
            {
                isNumber = false;
                // Code die vraagt om nummer: 
                isNumber = true;
            } while (isNumber);
            /* Wanneer?
             * Eerst uitvoeren, dan checken of 't nog een keertje opnieuw mag!
             * Stapgrootte onbekend
             * Niet bekend hoe vaak we loopen */

            // Foreach-loop
            int[] numbers = new int[2];
            foreach(int number in numbers)
            {

            }
            /* Wanneer?
             * We willen beginnen bij het begin
             * We willen alle elementen uit de verzameling
             * We weten het einde niet */

            // (recursie)
            
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
