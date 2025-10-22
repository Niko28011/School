using System.Security.Cryptography.X509Certificates;

namespace Myfirstconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til min første console!");
            Console.WriteLine("Mit navn er Nikolaj Frederiksen");
            Console.WriteLine("Og jeg vil gerne være datamatiker");
            Console.WriteLine();

            Console.Write("Hvad er dit fornavn?:");
            string firstname;
            firstname = Console.ReadLine();
            Console.WriteLine("Dit fornavn er " + firstname);
            Console.Write("Hvad er dit efternavn?:");
            string lastname;
            lastname = Console.ReadLine();
            Console.WriteLine("Og dit efternavn er " + lastname);
            Console.WriteLine();
            Console.WriteLine("Velkommen til " + firstname + " " + lastname);

        }
    }
}
