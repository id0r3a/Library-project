using static System.Reflection.Metadata.BlobBuilder;

namespace Library_project
{
    public class User : Book
    {
        public List<Book> books = new List<Book>();

        public void SearchBook()
        {
            Console.WriteLine("Enter search term: ");
            string searchTerm = Console.ReadLine();
            foreach (Book book in books)
            {
                if (book.Title.Contains(searchTerm) || book.Author.Contains(searchTerm))
                {
                    book.DisplayBookInfo();
                }

                else
                {
                    Console.WriteLine("No books found");
                }
            }

        }


        public void ViweBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }


    }


}
