using System;
using System.Collections.Generic;

namespace BooksLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgrammTools tolls = new ProgrammTools();
            List<String> authors = new List<string> { "SomeOne", "NoOne", "FewOne" };
            List<String> authors2 = new List<string> { "SomeTwo", "NoTwo", "FewTwo" };
            Book book = new Book(authors, "house", "name", 200, 1994);
            Book book2 = new Book(authors2, "moos", "coos", 156, 1998);
            LibraryCard card = new LibraryCard(book, 20);
            LibraryCard card1 = new LibraryCard(book, 10);
            LibraryCard card2 = new LibraryCard(book2, 30);
            Console.WriteLine(card.ToString());
            Console.WriteLine(card1.ToString());
            Console.WriteLine(card2.ToString());
            Console.WriteLine(book.ToString()); 
            Console.WriteLine(book2.ToString());
            Console.WriteLine(card2.Equals(card1));
            Console.WriteLine(card1.Equals(card));
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.Equals(book2));
            LibrarySystem librarySystem = new LibrarySystem();
            Console.WriteLine(librarySystem.AddCard(card));
            Console.WriteLine(librarySystem.AddCard(card1));
            Console.WriteLine(librarySystem.AddCard(card2));
            tolls.PrintResults(librarySystem.SearchByFragmentBookName("na"));
            Console.WriteLine(librarySystem.SearchByBookName("name"));
            Console.WriteLine(librarySystem.SearchByBookName("mane"));
            Console.WriteLine(librarySystem.SearchByBookName("name"));


            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
