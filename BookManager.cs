using System;
using System.Collections.Generic;

namespace Library_project
{
    public class BookManager
    {
        public List<Book> Books { get; set; }
        public List<Book> AvailableBooks { get; set; }
        public List<Book> CheckedOutBooks { get; set; }

        public BookManager()
        {
            Books = new List<Book>(); 
            AvailableBooks = new List<Book>(); 
            CheckedOutBooks = new List<Book>();

            // Add initial books
            var book1 = new Book("Harry Potter", "JK Rowling", 111);
            var book2 = new Book("Mikaels värld", "Dorsa", 222);
            var book3 = new Book("Isaks resa", "Ikran", 333);

            Books.Add(book1);
            AvailableBooks.Add(book1);
            Books.Add(book2);
            AvailableBooks.Add(book2);
            Books.Add(book3);
            AvailableBooks.Add(book3);
        }

        public void PrintAvailableBooks()
        {
            if (AvailableBooks.Count > 0)
            {
                foreach (var book in AvailableBooks)
                {
                    book.DisplayBookInfo();
                }
            }
            else
            {
                Console.WriteLine("Det finns inga tillgängliga böcker.");
            }
        }

        public void CheckOutBook(int isbn)
        {
            Book book = AvailableBooks.Find(b => b.ISBN == isbn);

            if (book != null)
            {
                book.IsCheckedOut = true;
                AvailableBooks.Remove(book);
                CheckedOutBooks.Add(book);
                Console.WriteLine($"Boken '{book.Title}' är nu utlånad.");
            }
            else
            {
                Console.WriteLine("Boken är inte tillgänglig.");
            }
        }

        public void ReturnBook(int isbn)
        {
            Book book = CheckedOutBooks.Find(b => b.ISBN == isbn);

            if (book != null)
            {
                book.IsCheckedOut = false;
                CheckedOutBooks.Remove(book);
                AvailableBooks.Add(book);
                Console.WriteLine($"Boken '{book.Title}' har återlämnats.");
            }
            else
            {
                Console.WriteLine("Boken finns inte bland de utlånade böckerna.");
            }
        }

        public static void FindSpecificBook(List<Book> boklista, string searchAuthor)
        {
            bool bookFound = false;

            foreach (Book bok in boklista)
            {
                if (bok.Author.ToUpper() == searchAuthor.ToUpper())
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
    }
}
