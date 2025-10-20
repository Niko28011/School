using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        // Properties (Lister af bøger og amuletter)
        public List<Book> Books { get; set; }
        public List<Amulet> Amulets { get; set; }

        // Constructor
        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
        }

        //Overloaded AddToList() metoder
        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
    }
}
