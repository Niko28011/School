using System.Threading.Channels;

namespace ReadTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\nikol\\Desktop\\Skole materiale\\Hello, World.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);

            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            
        }
    }
}
