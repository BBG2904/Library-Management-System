using Library_Management_System.Implementations;

namespace Library_Management_System.Interfaces
{
    public interface ICheckoutService
    {
        void  BorrowBooks(int patronId, List<Implementations.Book> books);

        void ReturnBooks(List<Book> books, int patronId);

        int FineCalculator( int delayDays);

        void GetCheckOutDetailsOfPatron(int patronId);
    }
}
