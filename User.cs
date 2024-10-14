namespace Library_project
{
    public class User : Book
    {
        // Den här delen är från "Tillägg-av-metoder-i-userklassen"
        public static void MenyOption()
        {
            Console.WriteLine("Välkomen till vårat Bibliotek");
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till ny bok.");
            Console.WriteLine("2.Sök bok efter förafattare.");
            Console.WriteLine("3.Visa alla böcker i samlingen.");
            Console.WriteLine("4.Checka ut/Retunera bok.");
            Console.WriteLine("5 Stänga av programmet.");

            string chooseMenuOption = Console.ReadLine();

            switch (chooseMenuOption)
            {
                case "1":
                    Console.WriteLine("Ny bok tillagd!");
                    break;

                case "2":
                    Console.WriteLine("Söker efter bok...");
                    break;

                case "3":
                    Console.WriteLine("Visar alla böcker...");
                    break;

                case "4":
                    Console.WriteLine("Checkar ut/returnerar bok...");
                    break;

                default:
                    Console.WriteLine("Felaktigt val,försök igen.");
                    break;
            }
        }

        // Den här delen är från "master"-grenen
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
