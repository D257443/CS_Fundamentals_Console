using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "hoi";
            string lastName = "hoi";
            int age;
            Console.WriteLine("Wat is jouw leeftijd?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}, wat een mooie leeftijd!", age, firstName, lastName);

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
