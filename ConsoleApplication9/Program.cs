using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        struct Book
        {
            public string Name;
            public string Author;
            public int Page;

            public override string ToString()
            {
                return String.Format($"{Name} - {Author} - {Page}");
            }
        }

        static void Main(string[] args)
        {
            Book book1;
            book1.Name = "CLR via C#";
            book1.Author = "Jeffrey Richter";
            book1.Page = 858;

            Console.WriteLine($"{book1.Name}");

            List<Book> books = new List<Book>
            {
                new Book { Name = "CLR via C#", Author = "Jeffrey Richter", Page = 857},
                new Book { Name = "C# 6.0 and the .NET 4.6 Framework", Author = "Andrew Troelsen", Page = 1400},
                new Book {Name = "Pro ASP.NET Core MVC", Author  = "Adam Freeman", Page = 1250}
            };

            Console.WriteLine($"{books[0]}");
            
        }
    }
}
