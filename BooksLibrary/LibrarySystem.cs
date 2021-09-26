using System;
using System.Collections.Generic;

namespace BooksLibrary
{
    class LibrarySystem
    {
        private List<LibraryCard> fileCabinet;
        List<LibraryCard> result;
        string res;
        int summs;
        bool flag;


        public LibrarySystem()
        {
            fileCabinet = new List<LibraryCard>();
            result = new List<LibraryCard>();
        }

        public string AddCard(LibraryCard card)
        {
            flag = true;
            foreach (LibraryCard item in fileCabinet)
            {
                if (item.Equals(card))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                fileCabinet.Add(card);
                res = "Card was added to file cabinet!";
            } else
            {
                res = "We already have this card!";
            }

            return res;
        }

        public List<LibraryCard> SearchByAuthor(string author)
        {
            result = new List<LibraryCard>();
            foreach (LibraryCard item in fileCabinet)
            {
                if (item.Book.Authors.Contains(author))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<LibraryCard> SearchByPublishHouse(string publishHouse)
        {
            result = new List<LibraryCard>();
            foreach (LibraryCard item in fileCabinet)
            {
                if (item.Book.PublishingHouse.Equals(publishHouse))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<LibraryCard> SearchByBookName(string bookName)
        {
            result = new List<LibraryCard>();
            foreach (LibraryCard item in fileCabinet)
            {
                if (item.Book.Name.Equals(bookName))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<LibraryCard> SearchByFragmentBookName(string fragment)
        {
            result = new List<LibraryCard>();
            foreach (LibraryCard item in fileCabinet)
            {
                if (item.Book.Name.Contains(fragment))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<LibraryCard> SearchByYear(int year)
        {
            result = new List<LibraryCard>();
            foreach (LibraryCard item in fileCabinet)
            {
                if (item.Book.YearOfPublishing >= year)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public string CountOfAllBook()
        {
            summs = 0;
            foreach (LibraryCard item in fileCabinet)
            {
                summs += item.Count;
            }
            return res = String.Format("Count of all books = {0}", summs);
        }

        public string CountOfAllCards()
        {
            summs = 0;
            summs = fileCabinet.Count;
            return res = String.Format("Count of all cards = {0}", summs);
        }

        
    }
}
