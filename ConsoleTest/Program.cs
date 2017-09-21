// Using zorgt ervoor dat je al geschreven(voorgebakken) code kan gebruiken. Wat er achter using staat zijn libraries met daaarin de code.

using System;
// Namespace is een woordenboek, naam van de namespace
// kan worden aangepast.
namespace ConsoleTest
{
    // Classes = P2
    class Program
    {
        // Static en void ook voor later!
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my first application.");

            int myScore = 5;
            int yourScore = 8;
            myScore = myScore + 4;
            Console.WriteLine("My score is: " + myScore);
            Console.WriteLine("But your score is: " + yourScore);
            
            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }
    }
}
