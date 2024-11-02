using Library_Management_System.Interfaces;

namespace Library_Management_System.Implementations
{
    public class Patron : IPatron
    {
        private readonly int id;
        private readonly string name;
        private readonly int phoneNumber;

        public int Id { 
            get{return id;} 
        }

        public string Name
        {
            get { return name; }
        }
        public Patron(int id, string name, int phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public void GetPatronDetail()
        {
            Console.WriteLine($"Patron{this.name} and phone number{this.phoneNumber}");
        }
    }
}
