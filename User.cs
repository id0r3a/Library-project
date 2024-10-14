namespace Library_project
{
    public class User
    {
        // Den här delen är från "Tillägg-av-metoder-i-userklassen"
        public static void MenyOption()

        {
            Book myBookCollection = new Book();

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
                        Console.WriteLine("Ny bok tillagd!");
                        break;

                    case "2":
                        Console.WriteLine("Söker efter bok...");
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

                        Console.WriteLine("Stänger av programmet...");
                        break;

                    default:
                        Console.WriteLine("Felaktigt val,försök igen.");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tack för att du använde vårt bibliotek. Programmet avslutas nu.");

        }



        
    }
}
