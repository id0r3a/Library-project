using static System.Reflection.Metadata.BlobBuilder;

namespace Library_project
{
    public class BookManager
    {
        public List<Book> Books { get; set; }
        public BookManager()
        {
            Books = new List<Book>(); 
            
            Books.Add(new Book("Harry Potter", "JK Rowling", 111));
            Books.Add(new Book("Mikaels värld", "Dorsa", 222));
            Books.Add(new Book("Isaks resa", "Ikran", 333));
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
        public void RemoveBook(string title)
        {
            if (Books.Count > 0)
            {
                Book bookToRemove = null;
                foreach (var book in Books)
                {
                    if (book.Title.ToUpper() == title.ToUpper())
                    {
                        bookToRemove = book;
                        break;
                    }
                }

                if (bookToRemove != null)
                {
                    Books.Remove(bookToRemove);
                    Console.WriteLine($"Boken '{title}' har tagits bort från samlingen.");
                }
                else
                {
                    Console.WriteLine($"Boken med titeln '{title}' hittades inte i samlingen.");
                }
            }
            else
            {
                Console.WriteLine("Det finns inga böcker i samlingen att ta bort.");

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



















