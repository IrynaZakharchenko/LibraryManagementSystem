using System.Collections.Generic;
using System.Linq;

namespace LMSModel
{
   public static class Bibliographies
   {
      public static ICollection<Bibliography> FindByTicketNumber(int ticketNumber)
      {
         IQueryable<Bibliography> query =
            from bibliography in DBInstance.DataContext.Bibliographies
            where bibliography.id_reader_ticket == ticketNumber
            select bibliography;

         return query.Count() > 0 ? query.ToList() : null;
      }

      public static Bibliography FindByInventoryCode(int inventoryCode)
      {
         IQueryable<Bibliography> query =
            from bibliography in DBInstance.DataContext.Bibliographies
            where bibliography.id_book_instance == inventoryCode
            select bibliography;

         return query.Count() > 0 ? query.First() : null;
      }
   }
}
