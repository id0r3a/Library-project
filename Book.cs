namespace Library_project
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public bool IsCheckedOut { get; set; }

        public Book(string title, string author, int isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsCheckedOut = false; // Initialize as not checked out
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Titel: {Title}, Författare: {Author}, ISBN: {ISBN}, Tillgänglighet: {(IsCheckedOut ? "Utlånad" : "Tillgänglig")}");
        }
    }
}
