using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int[] numbers = new int[5];

            numbers[0] = 10;
            numbers[1] = 10;
            numbers[2] = 20;
            numbers[3] = 5;
            numbers[4] = 845980923;

            Console.WriteLine("Welk nummer wil je van me weten?");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Het cijfer op plek 1: {0}", numbers[0]);
                    break;
                case "2":
                    Console.WriteLine("Het cijfer op plek 2: {0}", numbers[1]);
                    break;
                case "3":
                    Console.WriteLine("Het cijfer op plek 3: {0}", numbers[2]);
                    break;
                case "4":
                    Console.WriteLine("Het cijfer op plek 4: {0}", numbers[3]);
                    break;
                case "5":
                    Console.WriteLine("Het cijfer op plek 5: {0}", numbers[4]);
                    break;
                default:
                    Console.WriteLine("Da's jammer, da's te hoog!");
                        break;
            }

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
