using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLibrary
{
    class ProgrammTools
    {
        public void PrintResults(List<LibraryCard>list)
        {
            foreach (LibraryCard item in list)
            {
                Console.WriteLine(item);
            }
        }


    }
}
