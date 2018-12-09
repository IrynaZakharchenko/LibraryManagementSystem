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

         throw new NotImplementedException();
      }

      public static void EditBook(Book book)
      {
         if (book == null)
         {
            throw new ArgumentNullException(nameof(book));
         }

         throw new NotImplementedException();
      }

      public static void DeleteBook(Book book)
      {
         if (book == null)
         {
            throw new ArgumentNullException(nameof(book));
         }

         throw new NotImplementedException();
      }

      public static void Save()
      {
         DBInstance.SubmitChanges();
      }
   }
}
