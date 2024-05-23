namespace _230524_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Harry Potter", 15, "Fantastic");
            Book book2 = new Book(2, "Serenad", 19.99, "Dram");
            Book book3 = new Book(3, "Elxan Elatli", 9.99, "Biography");
            Book book4 = new Book(4, "This spoke zarathustra", 12.49, "Philosophy");
            Book book5 = new Book(5, "Antichrist", 5.49, "Philosophy");
            Book book6 = new Book(6, "Bible", 7.99, "Religions");

            Library pb201 = new Library();
            pb201.AddBook(book1);
            pb201.AddBook(book2);
            pb201.AddBook(book3);
            pb201.AddBook(book4);
            pb201.AddBook(book5);
            pb201.AddBook(book6);

            //foreach (var book in pb201.GetFilteredBooks("fantastic"))
            //{
            //    Console.WriteLine(book.Name + " - " + book.Genre);
            //}
            foreach (var book in pb201.GetFilteredBooks(minPrice: 0, maxPrice: 350))
            {
                Console.WriteLine(book.Name + " - " + book.Price + " azn ");
            }
        }
    }
}
