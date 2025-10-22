namespace Øvelse_3._2___Videre_med_navn_og_alder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bed brugeren om navn
            Console.Write("Indtast dit navn: ");
            string navn = Console.ReadLine();

            // Bed brugeren om alder
            Console.Write("Indtast din alder: ");
            int alder = Convert.ToInt32(Console.ReadLine());

            // Bestem livsfase
            string livsfase;

            if (alder >= 0 && alder <= 12)
            {
                livsfase = "et barn";
            }
            else if (alder >= 13 && alder <= 19)
            {
                livsfase = "en teenager";
            }
            else if (alder >= 20 && alder <= 25)
            {
                livsfase = "en studerende";
            }
            else if (alder >= 26 && alder <= 67)
            {
                livsfase = "i arbejde";
            }
            else
            {
                livsfase = "en pensionist";
            }

            // Udskriv resultat
            Console.WriteLine($"{navn} er {alder} år gammel og er {livsfase}.");
        }
    }
}
