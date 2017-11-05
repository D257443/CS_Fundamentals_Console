using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsopdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;

            Console.WriteLine("Geef het eerste getal");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Geef het tweede getal");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Geef het derde getal");
            num3 = double.Parse(Console.ReadLine());

            if (num1 >= 101 || num2 >= 101 || num3 >= 101)
            {
                Console.WriteLine("Je hebt gefaald, een van je getallen was of gelijk aan of groter dan 101");
                Console.ReadLine();
                Environment.Exit(1);
            }
            if(num1 <= 0 || num2 <= 0 || num3 <= 0)
            {
                Console.WriteLine("Je hebt gefaald, een van je getallen was gelijk aan of lager dan 0");
                Console.ReadLine();
                Environment.Exit(1);
            }
            double gemiddeld = (num1 + num2 + num3) / 3;
            Console.WriteLine("Het gemiddelde is {0:0.00}.", gemiddeld);

            if(gemiddeld <= 55)
            {
                Console.WriteLine("Het gemiddelde is onvoldoende.");
            }
            else
            {
                Console.WriteLine("Het gemiddelde is voldoende");
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
