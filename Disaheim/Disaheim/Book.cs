using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string itemId) : base(itemId)
        {
        }

        public Book(string itemId, string title) : base(itemId)
        {
            Title = title;
        }

        public Book(string itemId, string title, double price) : this(itemId, title)
        {
            Price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}

