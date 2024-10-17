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


        public Book(string title, string author, int isbn)
        {
           Title = title;
            Author = author;
            ISBN = isbn;
        }

    }

}
