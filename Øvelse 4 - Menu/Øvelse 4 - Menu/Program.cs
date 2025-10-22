namespace Øvelse_4___Menu
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            while (true)//laver en loop, som gør programmet køre indtil break
            { 
            Console.WriteLine("Velkommen til min fantastiske menu:");
            Console.WriteLine();
            Console.WriteLine("1. Gør dit");
            Console.WriteLine("2. Gør dat");
            Console.WriteLine("3. Gør noget");
            Console.WriteLine("4. Få svaret på livet, universet og alting");
            Console.WriteLine();
            Console.Write("Valg menupunktet (1,2,3 eller 4):");

            string valg = Console.ReadLine();//læser brugerens input og gemmer det i en variabel, kunne også være en int

                if (valg == "1")//hvis brugeren skriver 1, gør dette
                {
                Console.WriteLine("Du har valgt punkt 1. Gør dit!");
            break;//stopper loopet
                }
            else if (valg == "2")//hvis brugeren skriver 2, gør dette
                {
                Console.WriteLine("Du har valgt punkt 2. Gør dat!");
            break;
            }
            else if (valg == "3")
            {
                Console.WriteLine("Du har valgt punkt 3. Gør noget!");
            break;
            }
            else if (valg == "4")
            {
                Console.WriteLine("Du har valgt punkt 4. svaret er 42");
            break;
            }
                else//hvis brugeren skriver noget andet, gør dette
             {
                Console.WriteLine("Ugyldigt valg. Prøv igen, tryk Enter.");

            }
                Console.ReadKey();//venter på at brugeren trykker Enter, før loopet starter forfra eller programmet lukker.
                Environment.Exit(0);//lukker programmet
            }



        }
    }
}
