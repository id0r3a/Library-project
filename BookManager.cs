using static System.Reflection.Metadata.BlobBuilder;

namespace Library_project
{
   public class BookManager
{
    public List<Book> Books { get; set; }
    public List<Book> availableBooks { get; set; }
    public List<Book> checkedOutBooks { get; set; }

    public BookManager()
    {
        Books = new List<Book>(); 
        availableBooks = new List<Book>(); 
        checkedOutBooks = new List<Book>();

        // Lägg till böcker i både Books och availableBooks
        var book1 = new Book("Harry Potter", "JK Rowling", 111);
        var book2 = new Book("Mikaels värld", "Dorsa", 222);
        var book3 = new Book("Isaks resa", "Ikran", 333);

        Books.Add(book1);
        availableBooks.Add(book1);
        Books.Add(book2);
        availableBooks.Add(book2);
        Books.Add(book3);
        availableBooks.Add(book3);
    }

    // Övriga metoder...



        public void PrintBooks()
        {
            if(Books.Count > 0) 
            {

            foreach (var book in Books)
            {
                Console.WriteLine($"Titel: {book.Title}, Författare: {book.Author}, ISBN: {book.ISBN}");
            }
            }
            else
            {
                Console.WriteLine("Det finns inga böcker i samlingen.");
            }
        }

        public static void FindSpecificBook(List<Book> boklista, string SearchAuthor)
        {
            bool bookFound = false;

            // Iterera genom boklistan för att hitta matchande författare
            foreach (Book bok in boklista)
            {
                if (bok.Author.ToUpper() == SearchAuthor.ToUpper())  // Jämför med stora och små bokstäver
                {
                    Console.WriteLine($"Här är boken av {bok.Author} som du sökte efter:");
                    Console.WriteLine($"Titel: {bok.Title}, ISBN: {bok.ISBN}");
                    bookFound = true;
                    break;
                }
            }

            if (!bookFound)
            {
                Console.WriteLine("Ingen bok hittades med den författaren.");
            }
        }

        public void CheckOutBook(int isbn)
        {
            Book book = availableBooks.Find(b => b.ISBN == isbn);

            if (book != null)
            {
                availableBooks.Remove(book);
                checkedOutBooks.Add(book);
                Console.WriteLine($"Boken '{book.Title}' är nu utlånad.");
            }
            else
            {
                Console.WriteLine("Boken är inte tillgänglig.");
            }
        }

       
        public void ReturnBook(int isbn)
        {
            Book book = checkedOutBooks.Find(b => b.ISBN == isbn);

            if (book != null)
            {
                checkedOutBooks.Remove(book);
                availableBooks.Add(book);
                Console.WriteLine($"Boken '{book.Title}' har återlämnats.");
            }
            else
            {
                Console.WriteLine("Boken finns inte bland de utlånade böckerna.");
            }
        }

    }
}



















