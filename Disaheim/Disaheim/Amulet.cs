using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        public string Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string itemId) : base(itemId)
        {
            Quality = Level.Medium;
        }

        public Amulet(string itemId, Level quality) : this(itemId)
        {
            Quality = quality;
        }

        public Amulet(string itemId, Level quality, string design) : this(itemId, quality)
        {
            Design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }


    }
}

