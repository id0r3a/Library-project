using System;
using System.Collections.Generic;

namespace Library_Project
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"ISBN: {ISBN}, Title: {Title}, Author: {Author}");
        }
    }

    public class BookManager
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Book> AvailableBooks { get; set; } = new List<Book>();
        public List<Book> CheckedOutBooks { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
            AvailableBooks.Add(book);
        }

        public void RemoveBook(int isbn)
        {
            Book book = FindBook(isbn);
            if (book != null)
            {
                Books.Remove(book);
                AvailableBooks.Remove(book);
                Console.WriteLine($"Removed: {book.Title}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void SearchBook(string searchTerm)
        {
            bool found = false;
            foreach (Book book in Books)
            {
                if (book.Title.Contains(searchTerm) || book.Author.Contains(searchTerm))
                {
                    book.DisplayInfo();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No books found.");
            }
        }

        public void ViewBooks()
        {
            foreach (Book book in Books)
            {
                book.DisplayInfo();
            }
        }

        public void CheckOutBook(int isbn)
        {
            Book book = FindBook(isbn);
            if (book != null && AvailableBooks.Contains(book))
            {
                AvailableBooks.Remove(book);
                CheckedOutBooks.Add(book);
                Console.WriteLine($"Checked out: {book.Title}");
            }
            else
            {
                Console.WriteLine("Book not available.");
            }
        }

        public void ReturnBook(int isbn)
        {
            Book book = FindCheckedOutBook(isbn);
            if (book != null)
            {
                CheckedOutBooks.Remove(book);
                AvailableBooks.Add(book);
                Console.WriteLine($"Returned: {book.Title}");
            }
            else
            {
                Console.WriteLine("Book not checked out.");
            }
        }

        public Book FindBook(int isbn)
        {
            return Books.Find(b => b.ISBN == isbn);
        }

        public Book FindCheckedOutBook(int isbn)
        {
            return CheckedOutBooks.Find(b => b.ISBN == isbn);
        }
    }
}
