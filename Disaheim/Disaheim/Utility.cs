using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        // Beregner værdi af en bog
       public double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        // Beregner værdien af en amulet
        public double GetValueOfAmulet(Amulet amulet)
        {
            double value = 0.0;

            switch (amulet.Quality)
            {
                case Level.Low:
                    value = 12.5;
                    break;
                case Level.Medium:
                    value = 20.0;
                    break;
                case Level.High:
                    value = 27.5;
                    break;
            }
            return value;
        }
    }
}
