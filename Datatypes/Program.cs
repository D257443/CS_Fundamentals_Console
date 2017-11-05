using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //uint = 0 -=- 4 miljard
            //int = -2,1 miljard -=- 2,1 miljard

            int number = 4;
            uint number2 = 4;

            // kommagetallen met een .
            // DataTypes voor kommagetallen
            // double is 64bit, zowel min als plus
            double number4 = 4.4;
            // float is 32bit, zowel min als plus
            float number5 = 4.4f;

            //datatypes voor karakters (tekst)
            // in een char sla je 1 karakter op (gebruik single quotes)
            // in een string sla je een reeks karakters op (gebruik double quotes)
            char letter = 'c';
            string word = "Game Over!";

            //Boolean kan false of true zijn (0 of 1)
            bool isPauze = false;

            // Input / Output ofwel IO
            string firstName;
            int age;

            Console.WriteLine("Voer uw voornaam in:");
            firstName = Console.ReadLine();

            Console.WriteLine("Voer je leeftijd in:");
            age = Convert.ToInt32( Console.ReadLine() );
            // age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hey, je ziet er goed uit vandaag, " + firstName + "!");

            Console.WriteLine("Hi {0}, wat zit je haar goed vandaag, {0}!", firstName, number, number2, number5, letter, word, isPauze, number4);
            Console.WriteLine("{0} jaar? Ik zou zeggen dat je {1} jaar was!", age, age - 18);
            Console.WriteLine(age);

            int a = 3;
            int b = 5;
            int c = a + b;
            a = c;
            a += b;
            a *= b;
            a /= b;
            a -= b;

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
