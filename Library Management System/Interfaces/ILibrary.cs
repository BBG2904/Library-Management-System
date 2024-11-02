using Library_Management_System.Implementations;

namespace Library_Management_System.Interfaces
{
    public interface ILibrary
    {
        void AddBooks(Book book);

        void RemoveBook(Book book);

        void AddPatrons(Patron patron);

       void RemovePatron(Patron patron);

        Patron? GetPatronDetails(int patronId);

        List<Book> GetAvailableBookDetails();
    }
}
