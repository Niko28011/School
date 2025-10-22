namespace Pr06
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double mælk;
            double brød;
            double smør;
            double nutella;
            double oksekød;

            //Console.WriteLine($"Mælk: {mælk}\nBrød: {brød}\nSmør: {smør}\nNutella: {nutella}\nOksekød: {oksekød}"); UDEN ARRAY

            double[] priser = {mælk,brød,smør,nutella,oksekød};
            for (int i = 0; i < priser.Length; i++)
            {
                Console.Write($"Pris for produkt {i + 1}:");
                priser[i] = Convert.ToDouble(Console.ReadLine());
            }
            double samletPris = 0;
            for (int i = 0;i < priser.Length;i++) 
            {

            
            
        }
    }
}
