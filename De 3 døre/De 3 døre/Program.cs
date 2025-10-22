using System;
using System.Runtime.ConstrainedExecution;

namespace De_3_døre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til de 3 døre");
            Console.Write("Du skal vælge en dør (1, 2 eller 3): ");
            string input = Console.ReadLine();

            if (input == "1");
            {
                string door1 = "Du har valgt dør 1. Bag denne dør er der en løve! Du er død.";
                Console.WriteLine(door1);
            }
            if (input == "2");
            {
                string door2 = "Du har valgt dør 2. Bag denne dør er der en løve! Du er død.";
                Console.WriteLine(door2);
            }
            if (input == "3");
            {
                string door3 = "Du har valgt dør 3. Bag denne dør er der en løve! Du er død.";
                Console.WriteLine(door3);
            }
            else
            {
                Console.WriteLine("Ugyldigt valg. Vælg venligst 1, 2 eller 3.");
            }
                Console.WriteLine("Tak fordi du spillede med!");
            Console.ReadLine();



        }
    }
}
