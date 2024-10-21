using System;

namespace Library_project
{
    public class User
    {
        public static void MenyOption()
        {
            BookManager myBookCollection = new BookManager();
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Välkommen till vårt bibliotek");
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till ny bok.");
                Console.WriteLine("2. Sök bok efter författare.");
                Console.WriteLine("3. Visa alla tillgängliga böcker.");
                Console.WriteLine("4. Checka ut/återlämna bok.");
                Console.WriteLine("5. Stäng av programmet.");

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
                        myBookCollection.AvailableBooks.Add(addedBook); // Also add to available books

                        Console.WriteLine("Tryck Enter för att fortsätta!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Skriv författarens namn på boken du söker efter: ");
                        string searchBook = Console.ReadLine();
                        BookManager.FindSpecificBook(myBookCollection.Books, searchBook);

                        Console.WriteLine("Tryck Enter för att fortsätta!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Detta är alla tillgängliga böcker i vår samling:");
                        myBookCollection.PrintAvailableBooks(); // Call the updated method
                        Console.WriteLine("Tryck Enter för att fortsätta.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.Write("Ange ISBN för boken du vill låna eller återlämna: ");
                        int bookIsbn = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Vill du (1) låna eller (2) återlämna boken? (ange 1 eller 2):");
                        string action = Console.ReadLine();
                        if (action == "1")
                        {
                            myBookCollection.CheckOutBook(bookIsbn);
                        }
                        else if (action == "2")
                        {
                            myBookCollection.ReturnBook(bookIsbn);
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt val. Försök igen.");
                        }
                        Console.WriteLine("Tryck Enter för att fortsätta.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        keepRunning = false;
                        Console.WriteLine("Tack för att du använde vårt bibliotek. Programmet avslutas nu.");
                        break;

                    default:
                        Console.WriteLine("Felaktigt val, försök igen.");
                        break;
                }
            }
        }
    }
}
