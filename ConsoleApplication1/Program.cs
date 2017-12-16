using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct Book
        {
            public string Title;
            public string Author;
            public int Pages;
            public int ID;

            public Book(string Title, string Author, int Pages, int ID)
            {
                this.Title = Title;
                this.Author = Author;
                this.Pages = Pages;
                this.ID = ID;
            }

            public override string ToString()
            {
                return String.Format($"{Title} - {Author} - {Pages} - {ID}");
            }
        }
        static void Main(string[] args)
        {
            Book book1 = new Book("Book 1", "Author 1", 899, 987056);
            Book book2 = new Book("Book 2", "Author 2", 444, 433564);
            Book book3 = new Book("Book 3", "Author 3", 907, 111435);
            Book book4 = new Book("Book 4", "Author 4", 790, 556835);

            List<Book> books = new List<Book>();            
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(new Book { Title = "Book 5", Author = "Author 5", Pages = 123, ID = 787453 });

            for (byte i = 0; i<5;i++)
                Console.WriteLine($"{books[i]}");

            
            //Console.WriteLine(book1);
            //Console.WriteLine(book2);
            //Console.WriteLine(book3);
            //Console.WriteLine(book4);
        }
    }
}
