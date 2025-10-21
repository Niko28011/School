using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        //Properties
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public Course(string name)
        {
            Name = name;
            DurationInMinutes = 0; //standardværdi
        }
        public Course(string namem, int durationInMinutes): this(namem) 
        {
            DurationInMinutes = durationInMinutes;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }

    }
}
