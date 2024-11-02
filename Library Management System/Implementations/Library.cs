using Library_Management_System.Interfaces;

namespace Library_Management_System.Implementations
{
    public class Library : ILibrary
    {
        public static List<Book> books = new List<Book>();
        private List<Patron> patrons = new List<Patron>();
        public void AddBooks(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Added book {book.Title} to library.");
        }

        public void AddPatrons(Patron patron)
        {
            patrons.Add(patron);
            Console.WriteLine($"Added patron{patron.Name} as a member.");
        }

        public List<Book> GetAvailableBookDetails()
        {
            Console.WriteLine("Available Book Details.");
            Console.WriteLine(Environment.NewLine);

            foreach (Book book in books)
            {
                if (book.Available)
                {
                    book.GetBookDetail();
                }
            }
            return books;
        }

        public Patron? GetPatronDetails(int patronId)
        {
            var patron = patrons.FirstOrDefault(x => x.Id == patronId);
            patron?.GetPatronDetail();
            return patron;
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
            Console.WriteLine($"Removed book {book.Title} from library.");
        }

        public void RemovePatron(Patron patron)
        {
            patrons.Remove(patron);
            Console.WriteLine($"Removed Patron {patron.Name} from a members.");
        }
    }
}
