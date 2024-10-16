using static System.Reflection.Metadata.BlobBuilder;

namespace Library_project
{
    public class Book
    {       
        //Attributer för huvudklassen
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public bool IsCheckedOut { get; set; }

        public List<Book> Books { get; set; }

        public Book(string title, string author, int isbn)
        {
           Title = title;
            Author = author;
            ISBN = isbn;
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
        public void PrintBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"Titel: {book.Title}, Författare: {book.Author}, ISBN: {book.ISBN}");
            }
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
