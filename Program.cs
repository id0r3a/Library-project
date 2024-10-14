namespace Library_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to grupp 7!");


            while (true)
            {
                User.MenyOption();
                
                string chooseMenuOptions = Console.ReadLine()!;
            }
        }

       
        }
    }
