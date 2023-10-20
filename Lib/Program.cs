using System.Xml.Linq;
using System.Text;
using USQLCSLibrary;
namespace LibraryConsoleApp
{
    class Program
    {
        static Library library = new Library();

        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        AddReader();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Неверный номер.");
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Добавить читателя");
            Console.WriteLine("3");
            Console.Write("Выберите действие: ");
        }

        static void AddBook()
        {
            Console.Write("Введите артикул: ");
            string articul = Console.ReadLine();

            Console.Write("Введите автора: ");
            string author = Console.ReadLine();

            Console.Write("Введите название: ");
            string title = Console.ReadLine();

            Console.Write("Введите год издания: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество экземпляров: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Book book = new Book
            {
                Articul = articul,
                Author = author,
                Title = title,
                Year = year,
                Quantity = quantity
            };
            
            library.AddBook(book);
            Console.WriteLine("Книга успешно добавлена.");
        }

        static void AddReader()
        {
            Console.Write("Введите ФИО читателя: ");
            string fullName = Console.ReadLine();

            Console.Write("Введите номер группы: ");
            string groupNumber = Console.ReadLine();
        }
    }
} 
