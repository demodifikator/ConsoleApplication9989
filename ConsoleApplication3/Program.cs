using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        //struct Book
        //{
        //    public string Title;
        //    public string Author;
        //    public int Pages;
        //    public int ID;

        //    public Book(string Title, string Author, int Pages, int ID)
        //    {
        //        this.Title = Title;
        //        this.Author = Author;
        //        this.Pages = Pages;
        //        this.ID = ID;
        //    }

        //    public override string ToString()
        //    {
        //        return String.Format($"{Title} - {Author} - {Pages} - {ID}");
        //    }
        //}

        static void Main(string[] args)
        {
            //List<Book> books = new List<Book>
            //{
            //    new Book ("CLR via C#", "Jeffrey Richter", 857, 123654),
            //    new Book {"C# 6.0 and the .NET 4.6 Framework", "Andrew Troelsen", 1400, 432654},
            //    new Book { "Pro ASP.NET Core MVC", "Adam Freeman", 1250, 765654}

            //};

            int[] array = { 3, 6, 4, 8, 9, 7 };
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i<array.Length;i++)
                Console.WriteLine(array[i]);
        }
    }
}
