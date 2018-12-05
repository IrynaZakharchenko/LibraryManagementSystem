using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    class LibraryOperations : ILibraryOperations
    {
        private List<BookInformation> booksList;
        
        public LibraryOperations(ref List<BookInformation> books)
        {
            booksList = books;
        }

        public void AddBook(BookInformation bookInformation)
        {
            booksList.Add(bookInformation);
        }

        public void DeleteBook(BookInformation bookInformation)
        {
            booksList.Remove(bookInformation);
        }

        public void EditBook(BookInformation bookInformation)
        {
            booksList.Add(bookInformation);
        }
    }
}
