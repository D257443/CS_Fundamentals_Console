using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            bool b = false;

            Console.WriteLine("Wat is je leeftijd?");
            Console.ReadLine();

            if ( age == 17 && b )
            {
                Console.WriteLine("Wordt ik uitgevoerd?");
            }
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
