using System.Collections.Generic;
using System.Linq;

namespace LMSModel
{
   public static class Books
   { 
      public static IDictionary<int, bool> FindInventoryCodesByISBN(int isbn)
      {
         IEnumerable<IGrouping<bool, int>> query =
            from instance in DBInstance.DataContext.Instances
            where instance.id_book_isbn == isbn
            group instance.id_book_inventory_num by instance.Bibliographies.Count() > 0;
         
         IDictionary<int, bool> inventoryCodes = null;

         if (query.Count() > 0)
         {
            inventoryCodes = new Dictionary<int, bool>();
            foreach (var inventoryCode in query)
            {
               foreach (int code in inventoryCode)
               {
                  inventoryCodes.Add(code, inventoryCode.Key);
               }
            }
         }
         return inventoryCodes;
      }

      public static string[] FindAutorsByISBN(int isbn)
      {
         IEnumerable<string> query =
            from author in DBInstance.DataContext.Book_related_Authors
            where author.id_book == isbn
            select author.Author.Name;

         return query.ToArray();
      }

      public static Book FindByInventoryCode(int inventoryCode)
      {
         IQueryable<Book> query =
            from instance in DBInstance.DataContext.Instances
            where instance.id_book_inventory_num == inventoryCode
            select instance.Book;

         return query.Count() > 0 ? query.First() : null;
      }

      public static Book FindByISBN(int isbn)
      {
         IQueryable<Book> query =
            from book in DBInstance.DataContext.Books
            where book.id_book_isbn == isbn
            select book;

         return query.Count() > 0 ? query.First() : null;
      }

      public static Book FindByTitle(string title)
      {
         IQueryable<Book> query =
            from book in DBInstance.DataContext.Books
            where book.title == title
            select book;

         return query.Count() > 0 ? query.First() : null;
      }

      public static Book[] FindByBookSeries(string bookSeries)
      {
         IQueryable<Book> query =
            from book in DBInstance.DataContext.Books
            where book.book_series == bookSeries
            select book;

         return query.Count() > 0 ? query.ToArray() : null;
      }

      public static Book[] FindByLanguage(string language)
      {
         IQueryable<Book> query =
            from book in DBInstance.DataContext.Books
            where book.language == language
            select book;

         return query.Count() > 0 ? query.ToArray() : null;
      }
   }
}
