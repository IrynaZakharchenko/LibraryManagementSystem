using LMSModel;
using System;
using System.Collections.Generic;

namespace LMSController
{
   internal class LibraryOperations : ILibraryOperations
   {
      public void AddBook(BookInformation bookInformation)
      {
         if (bookInformation == null)
         {
            throw new ArgumentNullException(nameof(bookInformation));
         }

         Book book = new Book()
         {
            annotation = bookInformation.Annotation,
            book_series = bookInformation.BookSeries,
            date_publish = bookInformation.PublishDate,
            full_title = bookInformation.FullTitle,
            title = bookInformation.Title,
            id_book_isbn = bookInformation.ISBN,
            PublishingHouse = new PublishingHouse()
            {
               name = bookInformation.PublishHouse.Name,
               category = bookInformation.PublishHouse.Category,
               location = bookInformation.PublishHouse.Location
            },
            language = bookInformation.Language,
            Subject = new Subject()
            {
               name = bookInformation.Subject.Name
            }
         };

         List<Author> authors = new List<Author>();
         foreach (var author in bookInformation.Authors)
         {
            authors.Add(new Author() { Name = author.Name });
         }

         Library.AddBook(book, authors, bookInformation.InventoryCode.Keys);
         Library.Save();
      }

      public void DeleteBookByISBN(int isbn)
      {
         Library.DeleteBookByISBN(isbn);
         Library.Save();
      }

      public void DeleteBookByInventoryCode(int inventoryCode)
      {
         Library.DeleteBookByInventoryCode(inventoryCode);
         Library.Save();
      }

      public void EditBook(BookInformation bookInformation)
      {
         if (bookInformation == null)
         {
            throw new ArgumentNullException(nameof(bookInformation));
         }

         Book book = new Book();

         Library.EditBook(book);
         Library.Save();
      }
   }
}
