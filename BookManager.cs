using static System.Reflection.Metadata.BlobBuilder;

namespace Library_project
{
    public class BookManager
    {
        public List<Book> Books { get; set; }
        public BookManager()
        {
            Books = new List<Book>(); //initerar listan


            // public List<Book> books = new List<Book>();

            // Lägg till böcker i listan


            Books.Add(new Book("Harry Potter", "JK Rowling", 111));
            Books.Add(new Book("Mikaels värld", "Dorsa", 222));
            Books.Add(new Book("Isaks resa", "Ikran", 333));
        
        }

        public void RemoveBook(int isbn)
        {
            Book bookToRemove = null;

            foreach (Book book in Books)
            {
                if (book.ISBN == isbn)
                {
                    bookToRemove = book;
                    break;
                }
            }
            if (bookToRemove != null)
            {
                Books.Remove(bookToRemove);
            }
            else
            {
                Console.WriteLine("Bok finns inte");
            }
        }

        public void ViweBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book);
            }
        }

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

        //public void CheckOutBook(int isbn)
        //{
        //    Book book = availableBooks.Find(b => b.ISBN == isbn);

        //    if (book != null)
        //    {
        //        availableBooks.Remove(book);
        //        checkedOutBooks.Add(book);
        //        Console.WriteLine($"Boken '{book.Title}' är nu utlånad.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Boken är inte tillgänglig.");
        //    }
        //}

        //// Returnera en bok :)
        //public void ReturnBook(int isbn)
        //{
        //    Book book = checkedOutBooks.Find(b => b.ISBN == isbn);

        //    if (book != null)
        //    {
        //        checkedOutBooks.Remove(book);
        //        availableBooks.Add(book);
        //        Console.WriteLine($"Boken '{book.Title}' har återlämnats.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Boken finns inte bland de utlånade böckerna.");
        //    }
        //}

    }
}



















