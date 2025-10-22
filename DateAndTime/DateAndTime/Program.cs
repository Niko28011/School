namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString()); viser tid og dato
            //Console.WriteLine(myValue.ToShortDateString()); viser kun dato
            //Console.WriteLine(myValue.ToShortTimeString()); viser kun tiden
            //Console.WriteLine(myValue.ToLongDateString()); viser lang dato med dag/månede/dato/år
            //Console.WriteLine(myValue.ToLongTimeString()); viser lang tid time/minut/sekunder

            //Console.WriteLine(myVlaue.AddDays(3).ToLongDateString()); viser hvilken dato vi har om 3 dage
            //Console.WriteLine(myValue.AddHours(3).ToShortTimeString()); viser tiden om 3 timer

            //Console.WriteLine(myValue.AddDays(-3).ToShortDateString()); trækker 3 dage fra

            //Console.WriteLine(myValue.Month.ToString()); viser kun månede

            //DateTime myBirthday = new DateTime(1998, 01, 28); sætter en fast dato fx fødselsdag
            //Console.WriteLine(myBirthday.ToString());

            DateTime myBirthday = DateTime.Parse("01/28/1998");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
