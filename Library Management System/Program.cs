using Library_Management_System.Implementations;
Console.Clear();
var book1 = new Book(1, "XAuthor", "XBook", "X123", true, null);
var book2 = new Book(2, "YAuthor", "YBook", "Y123", true, null);
var book3 = new Book(3, "ZAuthor", "ZBook", "Z123", true, null);

var patron1 = new Patron(1, "x", 123321567);
var patron2 = new Patron(2, "y", 223321564);
var patron3 = new Patron(3, "z", 323321568);

var library = new Library();
//add books
library.AddBooks(book1);
library.AddBooks(book2);
library.AddBooks(book3);
Console.WriteLine(Environment.NewLine);
//add patrons
library.AddPatrons(patron1);
library.AddPatrons(patron2);
library.AddPatrons(patron3);
//Get available book details
Console.WriteLine(Environment.NewLine);
library.GetAvailableBookDetails();

//checkout  book1 and book 2 by patron 1
var checkoutService = new CheckoutService();
checkoutService.BorrowBooks(1, [book1, book2]);
Console.WriteLine(Environment.NewLine);
checkoutService.GetCheckOutDetailsOfPatron(1);
Console.WriteLine(Environment.NewLine);

//Get available book details after books checkout by patron 1
library.GetAvailableBookDetails();

//Patron 1 return books with fine.
Console.WriteLine(Environment.NewLine);
book1.DueDate = DateTime.Now.AddDays(-1);
book2.DueDate = DateTime.Now.AddDays(-3);
checkoutService.ReturnBooks([book1, book2], 1);

//Get available book details after books returned by patron 1.
Console.WriteLine(Environment.NewLine);
library.GetAvailableBookDetails();