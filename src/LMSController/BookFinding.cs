using System.Collections.Generic;

namespace LMSController
{
   internal class BookFinding : IBookFinding
   {
      private readonly List<BookInformation> booksList;

      public BookFinding()
      {
      }

      public BookFinding(ref List<BookInformation> list)
      {
         booksList = list;
      }

      public BookInformation FindBookByInventoryCode(int inventoryCode)
      {
         return new BookInformation();
      }

      public BookInformation FindBookByISBN(int isbn)
      {
         return booksList.Find(book => book.ISBN == isbn);
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

      BookInformation IBookFinding.FindBookByTitle(string title)
      {
         return booksList.Find(book => book.Title == title);
      }
   }
}
