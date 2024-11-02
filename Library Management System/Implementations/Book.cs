using Library_Management_System.Interfaces;

namespace Library_Management_System.Implementations
{
    public class Book : IBook
    {
        private readonly int id;
        private readonly string author;
        private readonly string title;
        private readonly string isbn;
        private  bool available;
        private  DateTime? dueDate;
        public string Title {
            get { return title; }
                
        }

        public DateTime? DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }
        public Book(int id, string author, string title, string iSBN, bool available, DateTime? dueDate)
        {
            this.id = id;
            this.author = author;
            this.title = title;
            this.isbn = iSBN;
            this.available = available;
            this.dueDate = dueDate;
        }

        public void GetBookDetail()
        {
            Console.WriteLine($"Book title {this.Title} and author name {this.author} and isbn detail{this.isbn}");
        }
    }
}
