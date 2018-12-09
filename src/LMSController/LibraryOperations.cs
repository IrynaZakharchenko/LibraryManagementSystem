using LMSModel;
using System;

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
         

         Library.AddBook(book);
      }

      public void DeleteBook(BookInformation bookInformation)
      {
         if (bookInformation == null)
         {
            throw new ArgumentNullException(nameof(bookInformation));
         }

         Book book = new Book();

         Library.DeleteBook(book);
      }

      public void EditBook(BookInformation bookInformation)
      {
         if (bookInformation == null)
         {
            throw new ArgumentNullException(nameof(bookInformation));
         }

         Book book = new Book();

         Library.EditBook(book);
      }
   }
}
