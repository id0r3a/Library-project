using System.ComponentModel.Design;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_project
{
    public class User
    {
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
                    Console.WriteLine();
                    break;

                case "2":
                    Console.WriteLine();
                    break;

                case "3":
                    Console.WriteLine();
                    break;

                case "4":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Felaktigt val,försök igen.");
                    break;
            }

        }
    }
}


