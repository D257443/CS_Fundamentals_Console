using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();



            string name = "abcde";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", name[i]);
            }

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();

            // een string is automatisch een array
            // Maak een string aan met 5 letters, en print die letters 1 voor 1 met een for-loop
        }
    }
}
