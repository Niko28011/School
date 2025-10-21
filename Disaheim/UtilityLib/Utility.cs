using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace UtilityLib
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
            if (amulet == null) return 0.0;

            string quality = amulet.Quality.ToString().ToLower();

            switch (quality)
            {
                case "low":
                    return 12.5;
                case "medium":
                    return 20.0;
                case "high":
                    return 27.5;
                default:
                    return 0.0;
            }
        }
        public double GetValueOfCourse(Course course)
        {
            if (course == null)
                return 0.0;

            int hours = (course.DurationInMinutes + 59) / 60;
            return hours * 875.0;
        }


    }
}
