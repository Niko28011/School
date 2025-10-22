namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast navn: ");
            string navn = Console.ReadLine();
            Console.WriteLine("Navn:" + navn);
            Console.Write("Indtast alder: ");
            string alder = Console.ReadLine();
            Console.WriteLine("Alder:" + alder);
            Console.WriteLine(navn + " er " + alder + " år gammel ");
            Console.ReadLine();
        }
    }
}
