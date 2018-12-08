using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
   class BookFinding : IBookFinding
   {
      private readonly List<BookInformation> booksList;

      public BookFinding(ref List<BookInformation> list)
      {
         booksList = list;
      }

      public BookInformation FindBookByInventoryCode(int inventoryCode)
      {
         return new BookInformation();
      }

      public BookInformation FindBookByIsbn(int isbn)
      {
         return booksList.Find(book => book.Isbn == isbn);
      }

      public BookInformation FindBookByTitle(string title)
      {
         return booksList.Find(book => book.Title == title);
      }

      BookInformation[] IBookFinding.FindBookByAuthors(AuthorInformation[] authors)
      {
         return booksList.FindAll(book => book.Authors == authors).ToArray();
      }

      BookInformation[] IBookFinding.FindBookByBookSeries(string bookSeries)
      {
         return booksList.FindAll(book => book.BookSeries == bookSeries).ToArray();
      }

      BookInformation[] IBookFinding.FindBookByLanguage(string language)
      {
          return booksList.FindAll(book => book.Language == language).ToArray();
      }
   }
}
