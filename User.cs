using static System.Reflection.Metadata.BlobBuilder;

namespace Library_project
{
    public class User
    {
        // Den här delen är från "Tillägg-av-metoder-i-userklassen"
        public static void MenyOption()

        {
            BookManager myBookCollection = new BookManager();

            bool keepRunning = true;

            while (keepRunning)
            {

                Console.WriteLine("Välkomen till vårat Bibliotek");
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("Tryck (1) för att lägga till ny bok.");
                Console.WriteLine("Tryck (2) för att sök bok efter förafattare.");
                Console.WriteLine("Tryck (3) för visa alla böcker i samlingen.");
                Console.WriteLine("Tryck (4) checka ut/Retunera bok.");
                Console.WriteLine("Tryck (5) för att stänga av programmet.");

                string chooseMenuOption = Console.ReadLine();

                switch (chooseMenuOption)
                {
                    case "1":
                        Console.WriteLine("Skriv följande info");

                        // Fråga användaren efter bokinformation
                        Console.WriteLine("Skriv boktiteln: ");
                        string title = Console.ReadLine();

                        Console.WriteLine("Skriv författaren: ");
                        string author = Console.ReadLine();

                        Console.WriteLine("Skriv ISBN: ");
                        int isbn = Convert.ToInt32(Console.ReadLine());

                        Book addedBook = new Book(title, author, isbn);
                        myBookCollection.Books.Add(addedBook);

                        Console.WriteLine("Tryck Enter for att fortsätta!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Skriv författarens namn på boken du söker efter: ");
                        string searchBook = Console.ReadLine().ToUpper();
                        Book.FindSpecificBook(myBookCollection.Books, searchBook);

                        Console.WriteLine("Tryck Enter for att fortsätta!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Detta är alla böcker i vår samling");
                        myBookCollection.PrintBooks();
                        Console.WriteLine(" ");
                        Console.WriteLine("Tryck enter för att fortsätta");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.WriteLine("Checkar ut/returnerar bok...");
                        break;
                    
                    case "5":
                        keepRunning = false;
                        Console.WriteLine("Tack för att du använde vårt bibliotek. Programmet avslutas nu.");
                        break;

                    default:
                        Console.WriteLine("Felaktigt val,försök igen.");
                        break;
                }
                Console.WriteLine();
            }

        }
        
    }
}
