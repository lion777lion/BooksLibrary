using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLibrary
{
    class LibraryCard
    {
        private Book book;
        private int count;
        string result;
        int summ;

        public Book Book { get => book; }

        public LibraryCard(Book book, int count)
        {
            if (book.IsValid == false)
            {
                Console.WriteLine("Book is not valid! Can't be accepted");
            }
            else
            {
                this.book = book;
                this.count = count;
            }
        }

        public int Count
        {
            get { return count; }
        }
        public string AddBook()
        {
            this.count++;
            result = "Book was returned!";
            return result;
        }
        public string AddBook(int bookCount)
        {
            this.count += bookCount;
            result = "Books was added!";
            return result;
        }
        public string GiveBook()
        {
            if (count > 0)
            {
                this.count--;
                result = "Book was give!";
                return result;
            } else
            {
                result = "Sorry! We dont have this book!";
                return result;
            }
        }
        public string GiveBook(int bookCount)
        {
            if (count > 0 && (count - bookCount) > 0)
            {
                this.count -= bookCount;
                result = "Book was give!";
                return result;
            }
            else
            {
                result = "Sorry! We dont have this book!";
                return result;
            }
        }
        public override string ToString()
        {
            return string.Format("{0, 20}{1, 5}", book, count);
        }
        public override bool Equals(object obj)
        {
            LibraryCard temp = (LibraryCard)obj;
            return this.book.Equals(temp.Book);
        }
        
    }

    
}
