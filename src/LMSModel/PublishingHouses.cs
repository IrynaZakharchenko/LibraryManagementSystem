using System;
using System.Linq;

namespace LMSModel
{
   public static class PublishingHouses
   {
      public static void Add(PublishingHouse publishingHouse)
      {
         if (publishingHouse == null)
         {
            throw new ArgumentNullException(nameof(publishingHouse));
         }

         DBInstance.DataContext.PublishingHouses.InsertOnSubmit(publishingHouse);
      }

      public static PublishingHouse FindByName(string name)
      {
         if (name == null)
         {
            throw new ArgumentNullException(nameof(name));
         }

         IQueryable<PublishingHouse> query =
            from publishingHouse in DBInstance.DataContext.PublishingHouses
            where publishingHouse.name == name
            select publishingHouse;

         return query.Count() > 0 ? query.First() : null;
      }

      public static void Save()
      {
         DBInstance.SubmitChanges();
      }

      public static void Delete(PublishingHouse publishingHouse)
      {
         if (publishingHouse == null)
         {
            throw new ArgumentNullException(nameof(publishingHouse));
         }


         DBInstance.DataContext.PublishingHouses.DeleteOnSubmit(publishingHouse);
      }
   }
}
