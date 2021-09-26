using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLibrary
{
    class Book : IComparable
    {
        List<String> authors;
        string publishingHouse, name;
        int pages, yearOfPublish;
        Boolean isValid;

        public Book(List<String> authors, string publishingHouse, string name,
                    int pages, int yearOfPublish)
        {
            this.authors = authors;
            this.name = name.ToUpper();
            this.publishingHouse = publishingHouse.ToUpper();
            this.pages = pages;
            this.yearOfPublish = yearOfPublish;
            this.isValid = true;
        }

        public Book()
        {
            this.isValid = false;
        }

        public List<String> Authors
        {
            get { return authors; }
        }

        public string PublishingHouse
        {
            get { return publishingHouse; }
        }

        public int YearOfPublishing
        {
            get { return yearOfPublish; }
        }

        public Boolean IsValid
        {
            get { return isValid; }
        }

        public string Name 
        {
            get { return name; }
        }

        public override string ToString()
        {
            return String.Format("{0, 10}, {1, 10}, {2, 10}, {3, 4}, {4, 4}",
                authors, name, publishingHouse, yearOfPublish, pages);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Book temp = (Book)obj;
            return authors[0].CompareTo(temp.authors[0]);
        }

        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   EqualityComparer<List<string>>.Default.Equals(authors, book.authors) &&
                   publishingHouse == book.publishingHouse &&
                   name == book.name &&
                   pages == book.pages &&
                   yearOfPublish == book.yearOfPublish;
        }
    }
}
