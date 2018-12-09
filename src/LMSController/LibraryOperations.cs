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

         Book book = new Book();

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
