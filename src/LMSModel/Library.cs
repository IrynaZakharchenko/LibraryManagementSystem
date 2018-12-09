using System;

namespace LMSModel
{
   public static class Library
   {
      public static void AddBook(Book book)
      {
         if (book == null)
         {
            throw new ArgumentNullException(nameof(book));
         }

         DBInstance.DataContext.Books.InsertOnSubmit(book);
      }

      public static void EditBook(Book book)
      {
         if (book == null)
         {
            throw new ArgumentNullException(nameof(book));
         }
      }

      public static void DeleteBook(Book book)
      {
         if (book == null)
         {
            throw new ArgumentNullException(nameof(book));
         }

         DBInstance.DataContext.Books.DeleteOnSubmit(book);
      }

      public static void Save()
      {
         DBInstance.SubmitChanges();
      }
   }
}
