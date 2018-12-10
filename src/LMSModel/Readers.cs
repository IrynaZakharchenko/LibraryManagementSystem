using System.Linq;

namespace LMSModel
{
   public static class Readers
   {
      public static Reader FindByLibraryTicket(int ticketNumber)
      {
         IQueryable<Reader> query =
            from reader in DBInstance.DataContext.Readers
            where reader.id_reader_ticket == ticketNumber
            select reader;

         return query.Count() > 0 ? query.First() : null;
      }

      public static Reader FindByName(string name)
      {
         if (name == null)
         {
            throw new System.ArgumentNullException(nameof(name));
         }

         IQueryable<Reader> query =
            from reader in DBInstance.DataContext.Readers
            where reader.Person.full_name == name
            select reader;

         return query.Count() > 0 ? query.First() : null;
      }

      public static void Add(Reader reader)
      {
         if (reader == null)
         {
            throw new System.ArgumentNullException(nameof(reader));
         }

         DBInstance.DataContext.Readers.InsertOnSubmit(reader);
      }

      public static void Edit(Reader reader)
      {
         if (reader == null)
         {
            throw new System.ArgumentNullException(nameof(reader));
         }

         if (reader.Person == null)
         {
            throw new System.ArgumentNullException(nameof(reader.Person));
         }

         Reader existingReader = FindByLibraryTicket(reader.id_reader_ticket);
         if (existingReader != null)
         {
            existingReader.Person = reader.Person;
         }
      }

      public static void Delete(int ticketNumber)
      {
         Reader existingReader = FindByLibraryTicket(ticketNumber);
         if (existingReader != null)
         {
            DBInstance.DataContext.Persons.DeleteOnSubmit(existingReader.Person);
            DBInstance.DataContext.Bibliographies.DeleteAllOnSubmit(existingReader.Bibliographies);
            DBInstance.DataContext.Readers.DeleteOnSubmit(existingReader);
         }
      }

      public static void RentBook(Reader reader, int inventoryCode)
      {
         if (reader == null)
         {
            throw new System.ArgumentNullException(nameof(reader));
         }

         DBInstance.DataContext.Bibliographies.InsertOnSubmit(new Bibliography()
         {
            give_date = System.DateTime.Now,
            id_reader_ticket = reader.id_reader_ticket,
            id_book_instance = inventoryCode
         });
      }

      public static void ReturnBook(int inventoryCode)
      {
         IQueryable<Bibliography> query =
            from bibliography in DBInstance.DataContext.Bibliographies
            where bibliography.id_book_instance == inventoryCode
            select bibliography;

         query.First().get_date = System.DateTime.Now;
      }
      
      public static void Save()
      {
         DBInstance.SubmitChanges();
      }
   }
}
