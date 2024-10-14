namespace Library_project
{
    public class User
    {
        // Den här delen är från "Tillägg-av-metoder-i-userklassen"
        public static void MenyOption()

        {

            bool keepRunning = true;

            while (keepRunning)
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
