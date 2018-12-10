using System;
using System.Collections.Generic;
using System.Linq;

namespace LMSModel
{
   public static class Library
   {
      public static void AddBook(Book book, List<Author> authors, ICollection<int> inventoryCodes)
      {
         if (book == null)
         {
            throw new ArgumentNullException(nameof(book));
         }

         if (authors == null)
         {
            throw new ArgumentNullException(nameof(authors));
         }

         if (inventoryCodes == null)
         {
            throw new ArgumentNullException(nameof(inventoryCodes));
         }

         List<Author> insertedAuthors = AddAuthors(authors);
         
         PublishingHouse publishingHouse = PublishingHouses.FindByName(book.PublishingHouse.name);
         if (publishingHouse != null)
         {
            book.PublishingHouse = publishingHouse;
         }

         IQueryable<Subject> query =
            from subject in DBInstance.DataContext.Subjects
            where subject.name == book.Subject.name
            select subject;

         if (query.Count() > 0)
         {
            book.Subject = query.First();
         }

         DBInstance.DataContext.Books.InsertOnSubmit(book);
         
         List<Instance> instances = new List<Instance>();
         foreach (var inventoryCode in inventoryCodes)
         {
            instances.Add(new Instance()
            {
               id_book_inventory_num = inventoryCode,
               Book = book
            });
         }
         if (instances.Count() > 0)
         {
            DBInstance.DataContext.Instances.InsertAllOnSubmit(instances);
         }

         List<Book_related_Author> book_related_Authors = new List<Book_related_Author>();
         foreach (var author in insertedAuthors)
         {
            book_related_Authors.Add(new Book_related_Author()
            {
               Book = book,
               Author = author
            });
         }

         DBInstance.DataContext.Book_related_Authors.InsertAllOnSubmit(book_related_Authors);
      }

      public static void EditBook(Book book)
      {
         if (book == null)
         {
            throw new ArgumentNullException(nameof(book));
         }
      }

      public static void DeleteBookByISBN(int isbn)
      {
         Book book = Books.FindByISBN(isbn);
         if (book != null)
         {
            DBInstance.DataContext.Books.DeleteOnSubmit(book);
         }
      }

      public static void DeleteBookByInventoryCode(int inventoryCode)
      {
         IQueryable<Instance> query =
            from instance in DBInstance.DataContext.Instances
            where instance.id_book_inventory_num == inventoryCode
            select instance;

         if (query.Count() > 0)
         {
            DBInstance.DataContext.Instances.DeleteOnSubmit(query.First());
         }
      }

      private static List<Author> AddAuthors(List<Author> newAuthors)
      {
         if (newAuthors == null)
         {
            throw new ArgumentNullException(nameof(newAuthors));
         }

         List<Author> authors = new List<Author>();
         foreach (var newAuthor in newAuthors)
         {
            IQueryable<Author> query =
               from author in DBInstance.DataContext.Authors
               where author.Name == newAuthor.Name
               select author;

            if (query.Count() == 0)
            {
               authors.Add(newAuthor);
            }
         }

         if (authors.Count() > 0)
         {
            DBInstance.DataContext.Authors.InsertAllOnSubmit(authors);
            Save();
         }

         authors.Clear();
         foreach (var newAuthor in newAuthors)
         {
            IQueryable<Author> query =
               from author in DBInstance.DataContext.Authors
               where author.Name == newAuthor.Name
               select author;

            if (query.Count() > 0)
            {
               authors.Add(query.First());
            }
         }

         return authors;
      }

      public static void Save()
      {
         DBInstance.SubmitChanges();
      }
   }
}
