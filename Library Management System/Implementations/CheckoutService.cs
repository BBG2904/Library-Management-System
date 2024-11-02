using Library_Management_System.Interfaces;

namespace Library_Management_System.Implementations
{
    public class CheckoutService : ICheckoutService
    {
        Dictionary<int,List<Book>> _checkOutDetails = new Dictionary<int,List<Book>>(); 
        public void BorrowBooks(int patronId, List<Book> books)
        {
            var linkBook =Library.books.Intersect(books);
            foreach (Book book in linkBook) 
            {
                if (! book.Available)
                {
                    throw new Exception($"Book{book.Title} not available");
                }
                book.DueDate = DateTime.Now.AddDays(5);
                book.Available = false;
            };

           _checkOutDetails.Add(patronId, books);
        }

        public int FineCalculator(int delayDays)
        {
          return 2 * delayDays;
        }

        public void ReturnBooks(List<Book> books, int patronId)
        {
            int totalFine = 0;
            var linkBook = Library.books.Intersect(books);
            foreach (Book book in linkBook)
            {
                book.Available = true;
                if (book.DueDate < DateTime.Now)
                {
                    TimeSpan delayDays = DateTime.Now - book.DueDate.Value;
                    totalFine += this.FineCalculator(delayDays.Days);
                };
            };
            Console.WriteLine($"Total Fine Paid: {totalFine}");
            Console.WriteLine("Books Returned");
            _checkOutDetails.Remove(patronId);
        }

        public void GetCheckOutDetailsOfPatron(int patronId)
        {
            Console.WriteLine("Checked Out Book Details of a Patron: "+patronId);
            Console.WriteLine(Environment.NewLine);
            if (_checkOutDetails.ContainsKey(patronId))
            {
                foreach (var book in _checkOutDetails[patronId])
                {
                    book.GetBookDetail();
                }
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }
}
