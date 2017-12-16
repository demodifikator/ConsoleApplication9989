using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        struct Book
        {
            public string Title;
            public string Author;
            public int ID;
            public int Page;

            public Book(int ID, string Author, string Title, int Page)
            {
                this.ID = ID;
                this.Author = Author;
                this.Title = Title;
                this.Page = Page;
            }

            public override string ToString()
            {
                return String.Format($"{ID} - {Author} - {Title} - {Page}");
            }
        }
        static void Main(string[] args)
        {
            Book[] books = new Book[4];
            
            for(int i = 0; i<books.Length; i++)
            {
                Console.Write("Введите ID книги: ");
                books[i].ID = int.Parse(Console.ReadLine());
                Console.Write("Введите автора книги: ");
                books[i].Author = Console.ReadLine();
                Console.Write("Введите название книги: ");
                books[i].Title = Console.ReadLine();
                Console.Write("Введите количество страниц: ");
                books[i].Page = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("ID\t\tAuthor\t\tTitle\t\tPages");
            for(int i =0;i<books.Length;i++)
            {
                Console.WriteLine($"{books[i].ID}\t\t{books[i].Author}\t\t{books[i].Title}\t\t{books[i].Page}");
            }
        }
    }
}
