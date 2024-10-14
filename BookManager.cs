

namespace Library_project
{
    public class BookManager
    {
        public List<Book> books = new List<Book>();




        public void AddBook(string title, string author, int isbn)
        {
            books.Add(new Book(title, author, isbn));
        }

        public void RemoveBook(int isbn)
        {
            Book bookToRemove = null;

            foreach (Book book in books)
            {
                if (book.ISBN == isbn)
                {
                    bookToRemove = book;
                    break;
                }
            }
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
        //public void SearchBook()
        //{
        //    Console.WriteLine("Enter search term: ");
        //    string searchTerm = Console.ReadLine();
        //    foreach (Book book in books)
        //    {
        //        if (book.Title.Contains(searchTerm) || book.Author.Contains(searchTerm))
        //        {
        //            book.DisplayBookInfo();
        //        }

        //        else
        //        {
        //            Console.WriteLine("No books found");
        //        }
        //    }
        //}

    
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

        // Returnera en bok :)
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