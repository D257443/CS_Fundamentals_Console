using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Voor alle getallen tussen 1 en 100 (inclusief!!)
            // Als het getal deelbaar is door 3 print Fizz + getal
            // Als het getal deelbaar is door 5 print Buzz + getal
            // Als het getal deelbaar is door 3 ÉN 5 print FizzBuzz + getal
            // Alle andere getallen niet laten zien!!!

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("{0} FizzBuzz", i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("{0} Fizz", i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("{0} Buzz", i);
                }
            }
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
