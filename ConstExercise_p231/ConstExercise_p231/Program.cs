using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstExercise_p231
{
    class Program
    {
        static void Main(string[] args)
        {
            const string libraryBranch = "Main Street Library";

            var newBooks = new List<Book>();

            Book hamlet = new Book("Hamlet", "William Shakespeare", 3);
            Book emma = new Book("Emma", "Jane Austen", 2);
            Book davidCopperfield = new Book("David Copperfield", "Charles Dickens");
            Book mobyDick = new Book("Moby-Dick", "Herman Melville");

            newBooks.Add(hamlet);
            newBooks.Add(emma);
            newBooks.Add(davidCopperfield);
            newBooks.Add(mobyDick);

            Console.WriteLine("Wecome to the {0}. These are our newest books:", libraryBranch);

            foreach (Book book in newBooks)
            {
                Console.WriteLine("{0} by {1}, total copies: {2}", book.Title, book.Author, book.Copies);
            }

            Console.ReadLine();
        }
    }
}
