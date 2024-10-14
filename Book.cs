﻿using static System.Reflection.Metadata.BlobBuilder;

namespace Library_project
{
    public class Book
    {       //Attributer för huvudklassen
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public bool IsCheckedOut { get; set; }

        public List<Book> Books { get; set; }

        public Book()
        {
            Books = new List<Book>();

            // Lägg till böcker i listan
            Books.Add(new Book("Harry Potter", "JK Rowling", 111));
            Books.Add(new Book("Mikaels värld", "Dorsa", 222));
            Books.Add(new Book("Isaks resa", "Ikran", 333));
        }

        public void PrintBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"Titel: {book.Title}, Författare: {book.Author}, Sidor: {book.ISBN}");
            }
        }

            public Book(string title, string author, int isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsCheckedOut = false;
        }
        ///Metod för att skriva ut information om boken
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Författare: {Author}");
            Console.WriteLine($"Titel: {Title}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Tillgänglighet: {(IsCheckedOut ? "Not available" : "Available")}");

        }
        
    }

}
