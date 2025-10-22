using System;

public class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lommeregner");

        // Brugeren indtaster to tal og en operator
        Console.Write("Indtast første tal: ");
        double tal1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Indtast en operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Indtast andet tal: ");
        double tal2 = Convert.ToDouble(Console.ReadLine());

        double resultat = 0;

        // Her bruges if-else
        if (op == "+")
        {
            resultat = tal1 + tal2;
            Console.WriteLine("Resultat: " + resultat);
        }
        else if (op == "-")
        {
            resultat = tal1 - tal2;
            Console.WriteLine("Resultat: " + resultat);
        }
        else if (op == "*")
        {
            resultat = tal1 * tal2;
            Console.WriteLine("Resultat: " + resultat);
        }
        else if (op == "/")
        {
            if (tal2 == 0)
            {
                Console.WriteLine("Fejl: Kan ikke dividere med 0!");
            }
            else
            {
                resultat = tal1 / tal2;
                Console.WriteLine("Resultat: " + resultat);
                
            }
        }
        else
        {
            Console.WriteLine("Ugyldig operator, prøv igen.");
        }
    }
}
