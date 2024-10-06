
using ExamLibrary.Function;
namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KnygaManager knygaManager = new KnygaManager();
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add knyga");
            Console.WriteLine("2. Remove knyga");
            Console.WriteLine("3. Sell knyga");
            Console.WriteLine("4. Find knyga by name");
            Console.WriteLine("5. Find knyga by avtor");
            Console.WriteLine("6. Find knyga by ganre");
            Console.WriteLine("7. Show all");
            Console.WriteLine("0. Exit");

            Console.Write("Enter choise: ");
            int choice = int.Parse(Console.ReadLine());
            while (true)
            {


                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name of knyga: ");
                        string name = Console.ReadLine();
                        knygaManager.AddKnyga(name);
                        break;
                    case 2:
                        Console.Write("Enter name of book for removing: ");
                        string removeknyga = Console.ReadLine();
                        knygaManager.RemoveKnyga(removeknyga);
                        break;
                    case 3:
                        Console.Write("Enter name knygi for sale: ");
                        string sellknyga = Console.ReadLine();
                        knygaManager.SellKnyga(sellknyga);
                        break;
                    case 4:
                        Console.Write("Enter book name: ");
                        string bookName = Console.ReadLine();
                        var foundBooks = knygaManager.SearchByName(bookName);
                        Console.WriteLine("Books found:");
                        foreach (var i in foundBooks)
                        {
                            Console.WriteLine($"- {i.Name} by {i.Avtor.SurName} ({i.Ganr.Name})");
                        }
                        break;

                    case 5:
                        Console.Write("Enter avthor surname: ");
                        string avthorSurname = Console.ReadLine();
                        var foundAuthors = knygaManager.SearchByAvtor(avthorSurname);
                        Console.WriteLine("Authors found:");
                        foreach (var avtor in foundAuthors)
                        {
                            Console.WriteLine($"- {avtor.SurName}");
                        }
                        break;

                    case 6:
                        Console.Write("Enter genre name: ");
                        string genrName = Console.ReadLine();
                        var foundGenr = knygaManager.SearchByGanre(genrName);
                        Console.WriteLine("Genres found:");
                        foreach (var ganr in foundGenr)
                        {
                            Console.WriteLine($"- {ganr.Name}");
                        }
                        break;

                    case 7:
                        knygaManager.ShowKnyga();
                        break;
                    case 0:
                        Console.WriteLine("Exit...");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}
